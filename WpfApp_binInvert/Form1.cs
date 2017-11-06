using System;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace WpfApp_binInvert
{    
    public partial class MainForm : Form
    {        
        public delegate void UpBar();
        UpBar d_UpBar;
        public delegate void SetLog(string s);
        SetLog t_log;
        Param pt;
        private static ManualResetEvent autoEvent = new ManualResetEvent(false);        

        public MainForm()
        {
            InitializeComponent();
            d_UpBar = new UpBar(pbProcess.PerformStep);
            t_log = new SetLog(doLog);
        }

        private void doLog(string s)
        {
            if (chbxLog.Checked)
            {
                tbxLog.Text += s + Environment.NewLine;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {            
            this.Close();
        }

        private void btnFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();
            if (fd.ShowDialog() == DialogResult.OK)
            {
                tbxFile.Text = fd.FileName;
            }
        }

        private void makeFile()
        {
            using (BinaryWriter writer = new BinaryWriter(File.Open(tbxFile.Text, FileMode.OpenOrCreate)))
            {
                for (byte i = 1; i < 11; i++)
                {
                    writer.Write(i);                    
                }
            }
        }

        private void pbSetStart(int x)
        {
            pbProcess.Minimum = 1;
            pbProcess.Maximum = x;
            pbProcess.Step = x / 100;            
            pbProcess.Value = 1;
        }        

        private void invertFile(object p)
        {
            Param pc = (Param)p;
            using (FileStream fstream = new FileStream(pc.s, FileMode.Open, FileAccess.ReadWrite))
            {
                byte[] lBuff = new byte[1];
                byte[] rBuff = new byte[1];
                long cc = 0;
                long pos = 0;
                
                Invoke(t_log, "Start Processing...");                
                DateTime tmeStrt = DateTime.Now;
                for (; pos < pc.l; pos++)
                {                    
                    fstream.Seek(pos, SeekOrigin.Begin);
                    fstream.Read(lBuff, 0, lBuff.Length);
                    
                    fstream.Seek((-1*(pos + 1)), SeekOrigin.End);
                    fstream.Read(rBuff, 0, rBuff.Length);

                    if (lBuff[0] != rBuff[0])
                    {
                        fstream.Seek((-1 * (pos + 1)), SeekOrigin.End);
                        fstream.Write(lBuff, 0, lBuff.Length);

                        fstream.Seek(pos, SeekOrigin.Begin);
                        fstream.Write(rBuff, 0, rBuff.Length);
                        cc++;                       
                    }
                    autoEvent.WaitOne();
                    pbProcess.Invoke(d_UpBar);                   
                }
                pbProcess.Invoke(d_UpBar);
                Invoke(t_log, "End Processing...");
                Invoke(t_log, "Count Replacements: " + cc.ToString());
                TimeSpan sp = DateTime.Now - tmeStrt;
                Invoke(t_log, "Time processing: " + sp.ToString());
            }
        }

        private void btnAction_Click(object sender, EventArgs e)
        {
            if (!File.Exists(tbxFile.Text))
            {
                MessageBox.Show("Cannot open this file.");
                return;
            }

            Thread tProc = new Thread(new ParameterizedThreadStart(invertFile));           
            bool isNewTr = tProc.IsAlive;

            if (btnAction.Text == "Run")
            {
                autoEvent.Set();
                if (!isNewTr)
                {
                    tbxLog.Clear();
                    FileInfo fi = new FileInfo(tbxFile.Text);
                    Param pt = new Param(tbxFile.Text, fi.Length / 2);
                    doLog("File " + pt.s + " is open.");
                    doLog("File length: " + fi.Length.ToString() + " bytes.");
                    pbSetStart((int)pt.l);
                    tProc.Start(pt);
                }                
                btnAction.Text = "Pause";
            }
            else if (btnAction.Text == "Pause")
            {
                autoEvent.Reset();
                btnAction.Text = "Run";
            }
        }
    }   

    public class Param
    {
        public string s;
        public long l;
        public Param(string s, long l)
        {
            this.s = s;
            this.l = l;
        }
    }
}
