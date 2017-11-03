using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WpfApp_binInvert
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
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

        private void invertFile()
        {
            using (FileStream fstream = new FileStream(tbxFile.Text, FileMode.Open, FileAccess.ReadWrite))
            {
                FileInfo fi = new FileInfo(tbxFile.Text);
                long mid = fi.Length / 2;
                pbProcess.Maximum = (int)mid;                

                byte[] lBuff = new byte[1];
                byte[] rBuff = new byte[1];

                for (long pos = 0; pos < mid; pos++)
                {
                    pbProcess.Value = (int)pos;
                    fstream.Seek(pos, SeekOrigin.Begin);
                    fstream.Read(lBuff, 0, lBuff.Length);
                    
                    fstream.Seek((-1*(pos + 1)), SeekOrigin.End);
                    fstream.Read(rBuff, 0, rBuff.Length);

                    if (lBuff != rBuff)
                    {
                        fstream.Seek((-1 * (pos + 1)), SeekOrigin.End);
                        fstream.Write(lBuff, 0, lBuff.Length);

                        fstream.Seek(pos, SeekOrigin.Begin);
                        fstream.Write(rBuff, 0, rBuff.Length);
                    }
                }
            }           
        }

        private void btnAction_Click(object sender, EventArgs e)
        {
            if (!File.Exists(tbxFile.Text))
            {
                MessageBox.Show("Cannot open this file.");
                return;
            }

            invertFile();
        }
    }
}
