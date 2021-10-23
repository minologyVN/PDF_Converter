namespace Client_Server
{
    partial class clientForm
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.txbFileName = new System.Windows.Forms.TextBox();
            this.btnUpFile = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txbPort = new System.Windows.Forms.TextBox();
            this.txbIP = new System.Windows.Forms.TextBox();
            this.btnConvertPDF = new System.Windows.Forms.Button();
            this.btnConvertTxt = new System.Windows.Forms.Button();
            this.btnConvertDoc = new System.Windows.Forms.Button();
            this.btnConvert = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.myProgressBar = new Client_Server.CustomControl1();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(90, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Idle";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // txbFileName
            // 
            this.txbFileName.Location = new System.Drawing.Point(49, 20);
            this.txbFileName.Name = "txbFileName";
            this.txbFileName.Size = new System.Drawing.Size(449, 20);
            this.txbFileName.TabIndex = 16;
            // 
            // btnUpFile
            // 
            this.btnUpFile.Location = new System.Drawing.Point(529, 13);
            this.btnUpFile.Name = "btnUpFile";
            this.btnUpFile.Size = new System.Drawing.Size(98, 33);
            this.btnUpFile.TabIndex = 15;
            this.btnUpFile.Text = "Upload File";
            this.btnUpFile.UseVisualStyleBackColor = true;
            this.btnUpFile.Click += new System.EventHandler(this.btnUpFile_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-55, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "File Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "State: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(209, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "Port:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(50, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 13);
            this.label5.TabIndex = 27;
            this.label5.Text = "IP:";
            // 
            // txbPort
            // 
            this.txbPort.Location = new System.Drawing.Point(244, 160);
            this.txbPort.Name = "txbPort";
            this.txbPort.Size = new System.Drawing.Size(130, 20);
            this.txbPort.TabIndex = 26;
            this.txbPort.Text = "5000";
            // 
            // txbIP
            // 
            this.txbIP.Location = new System.Drawing.Point(76, 160);
            this.txbIP.Name = "txbIP";
            this.txbIP.Size = new System.Drawing.Size(127, 20);
            this.txbIP.TabIndex = 25;
            this.txbIP.Text = "127.0.0.1";
            // 
            // btnConvertPDF
            // 
            this.btnConvertPDF.Location = new System.Drawing.Point(452, 111);
            this.btnConvertPDF.Name = "btnConvertPDF";
            this.btnConvertPDF.Size = new System.Drawing.Size(136, 33);
            this.btnConvertPDF.TabIndex = 24;
            this.btnConvertPDF.Text = "Convert to PDF";
            this.btnConvertPDF.UseVisualStyleBackColor = true;
            this.btnConvertPDF.Click += new System.EventHandler(this.btnConvertPDF_Click);
            // 
            // btnConvertTxt
            // 
            this.btnConvertTxt.Location = new System.Drawing.Point(309, 111);
            this.btnConvertTxt.Name = "btnConvertTxt";
            this.btnConvertTxt.Size = new System.Drawing.Size(137, 33);
            this.btnConvertTxt.TabIndex = 23;
            this.btnConvertTxt.Text = "Convert to Text";
            this.btnConvertTxt.UseVisualStyleBackColor = true;
            this.btnConvertTxt.Click += new System.EventHandler(this.btnConvertTxt_Click);
            // 
            // btnConvertDoc
            // 
            this.btnConvertDoc.Location = new System.Drawing.Point(174, 111);
            this.btnConvertDoc.Name = "btnConvertDoc";
            this.btnConvertDoc.Size = new System.Drawing.Size(129, 33);
            this.btnConvertDoc.TabIndex = 22;
            this.btnConvertDoc.Text = "Convert to Word.doc";
            this.btnConvertDoc.UseVisualStyleBackColor = true;
            this.btnConvertDoc.Click += new System.EventHandler(this.btnConvertDoc_Click);
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(49, 111);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(119, 33);
            this.btnConvert.TabIndex = 21;
            this.btnConvert.Text = "Convert to Word.docx";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 29;
            this.label6.Text = "File: ";
            // 
            // myProgressBar
            // 
            this.myProgressBar.Location = new System.Drawing.Point(49, 82);
            this.myProgressBar.Name = "myProgressBar";
            this.myProgressBar.Size = new System.Drawing.Size(449, 23);
            this.myProgressBar.TabIndex = 31;
            // 
            // clientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 211);
            this.Controls.Add(this.myProgressBar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txbPort);
            this.Controls.Add(this.txbIP);
            this.Controls.Add(this.btnConvertPDF);
            this.Controls.Add(this.btnConvertTxt);
            this.Controls.Add(this.btnConvertDoc);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txbFileName);
            this.Controls.Add(this.btnUpFile);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "clientForm";
            this.Text = "clientForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox txbFileName;
        private System.Windows.Forms.Button btnUpFile;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txbPort;
        private System.Windows.Forms.TextBox txbIP;
        private System.Windows.Forms.Button btnConvertPDF;
        private System.Windows.Forms.Button btnConvertTxt;
        private System.Windows.Forms.Button btnConvertDoc;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.Label label6;
        private CustomControl1 myProgressBar;
    }
}

