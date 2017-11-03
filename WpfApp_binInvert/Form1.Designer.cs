namespace WpfApp_binInvert
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pbProcess = new System.Windows.Forms.ProgressBar();
            this.btnFile = new System.Windows.Forms.Button();
            this.tbxFile = new System.Windows.Forms.TextBox();
            this.btnAction = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.chbxLog = new System.Windows.Forms.CheckBox();
            this.grbxFile = new System.Windows.Forms.GroupBox();
            this.grbxProc = new System.Windows.Forms.GroupBox();
            this.grbxLog = new System.Windows.Forms.GroupBox();
            this.tbxLog = new System.Windows.Forms.TextBox();
            this.grbxFile.SuspendLayout();
            this.grbxProc.SuspendLayout();
            this.grbxLog.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbProcess
            // 
            this.pbProcess.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbProcess.Location = new System.Drawing.Point(6, 17);
            this.pbProcess.Name = "pbProcess";
            this.pbProcess.Size = new System.Drawing.Size(271, 22);
            this.pbProcess.TabIndex = 0;
            // 
            // btnFile
            // 
            this.btnFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFile.Location = new System.Drawing.Point(281, 17);
            this.btnFile.Name = "btnFile";
            this.btnFile.Size = new System.Drawing.Size(75, 23);
            this.btnFile.TabIndex = 1;
            this.btnFile.Text = "Open File";
            this.btnFile.UseVisualStyleBackColor = true;
            this.btnFile.Click += new System.EventHandler(this.btnFile_Click);
            // 
            // tbxFile
            // 
            this.tbxFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxFile.Location = new System.Drawing.Point(6, 19);
            this.tbxFile.Name = "tbxFile";
            this.tbxFile.Size = new System.Drawing.Size(271, 20);
            this.tbxFile.TabIndex = 2;
            // 
            // btnAction
            // 
            this.btnAction.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAction.Location = new System.Drawing.Point(281, 17);
            this.btnAction.Name = "btnAction";
            this.btnAction.Size = new System.Drawing.Size(75, 23);
            this.btnAction.TabIndex = 3;
            this.btnAction.Text = "Run";
            this.btnAction.UseVisualStyleBackColor = true;
            this.btnAction.Click += new System.EventHandler(this.btnAction_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.Location = new System.Drawing.Point(289, 174);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Quit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // chbxLog
            // 
            this.chbxLog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chbxLog.AutoSize = true;
            this.chbxLog.Location = new System.Drawing.Point(212, 19);
            this.chbxLog.Name = "chbxLog";
            this.chbxLog.Size = new System.Drawing.Size(59, 17);
            this.chbxLog.TabIndex = 5;
            this.chbxLog.Text = "Enable";
            this.chbxLog.UseVisualStyleBackColor = true;
            // 
            // grbxFile
            // 
            this.grbxFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grbxFile.Controls.Add(this.btnFile);
            this.grbxFile.Controls.Add(this.tbxFile);
            this.grbxFile.Location = new System.Drawing.Point(8, 8);
            this.grbxFile.Name = "grbxFile";
            this.grbxFile.Size = new System.Drawing.Size(362, 46);
            this.grbxFile.TabIndex = 6;
            this.grbxFile.TabStop = false;
            this.grbxFile.Text = "File";
            // 
            // grbxProc
            // 
            this.grbxProc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grbxProc.Controls.Add(this.pbProcess);
            this.grbxProc.Controls.Add(this.btnAction);
            this.grbxProc.Location = new System.Drawing.Point(8, 60);
            this.grbxProc.Name = "grbxProc";
            this.grbxProc.Size = new System.Drawing.Size(362, 46);
            this.grbxProc.TabIndex = 7;
            this.grbxProc.TabStop = false;
            this.grbxProc.Text = "Processing";
            // 
            // grbxLog
            // 
            this.grbxLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grbxLog.Controls.Add(this.tbxLog);
            this.grbxLog.Controls.Add(this.chbxLog);
            this.grbxLog.Location = new System.Drawing.Point(8, 112);
            this.grbxLog.Name = "grbxLog";
            this.grbxLog.Size = new System.Drawing.Size(277, 85);
            this.grbxLog.TabIndex = 8;
            this.grbxLog.TabStop = false;
            this.grbxLog.Text = "Logging";
            // 
            // tbxLog
            // 
            this.tbxLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxLog.Location = new System.Drawing.Point(6, 19);
            this.tbxLog.Multiline = true;
            this.tbxLog.Name = "tbxLog";
            this.tbxLog.ReadOnly = true;
            this.tbxLog.Size = new System.Drawing.Size(200, 60);
            this.tbxLog.TabIndex = 6;
            this.tbxLog.Text = "log frame...";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 202);
            this.Controls.Add(this.grbxLog);
            this.Controls.Add(this.grbxProc);
            this.Controls.Add(this.grbxFile);
            this.Controls.Add(this.btnExit);
            this.MinimumSize = new System.Drawing.Size(390, 240);
            this.Name = "MainForm";
            this.Text = "BinInvert";
            this.grbxFile.ResumeLayout(false);
            this.grbxFile.PerformLayout();
            this.grbxProc.ResumeLayout(false);
            this.grbxLog.ResumeLayout(false);
            this.grbxLog.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ProgressBar pbProcess;
        private System.Windows.Forms.Button btnFile;
        private System.Windows.Forms.TextBox tbxFile;
        private System.Windows.Forms.Button btnAction;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.CheckBox chbxLog;
        private System.Windows.Forms.GroupBox grbxFile;
        private System.Windows.Forms.GroupBox grbxProc;
        private System.Windows.Forms.GroupBox grbxLog;
        private System.Windows.Forms.TextBox tbxLog;
    }
}

