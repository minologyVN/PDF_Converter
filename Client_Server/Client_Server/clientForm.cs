﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client_Server
{
    public partial class clientForm : Form
    {
        public clientForm()
        {
            InitializeComponent();
        }
        public static FileDialog ofd;
        public static string convertType;
        static Client client;
        static int progress = 1;
        private void timer1_Tick(object sender, EventArgs e)
        {
            myProgressBar.Minimum = 0;
            myProgressBar.Maximum = 100;
            if (!label1.Text.Equals(Client.MessageCurrent))
            {
                label1.Text = Client.MessageCurrent;
                myProgressBar.Value = 1+ progress * 33;
                progress++;
            }

            
               // Thread.Sleep(50);
            
        }

        public static int luot = 0;
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            try {
                client.SendFile(ofd.FileName, convertType);
                ++luot;
                //Client.SendFile(ofd.FileName, convertType,txbIP.Text,Convert.ToInt32(txbPort.Text));
            }
            // thay client.sendfile();
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }

        private void btnUpFile_Click(object sender, EventArgs e)
        {
            using ( ofd = new OpenFileDialog() { Filter = " Files |*.pdf;*.doc;*.docx;*.txt" })
            {
                try
                {
                    if (ofd.ShowDialog() == DialogResult.OK)
                    {
                        //
                        txbFileName.Text = ofd.FileName;
                        if (txbFileName.Text.Contains(".pdf"))
                        {
                            btnConvertPDF.Enabled = false;
                            btnConvertTxt.Enabled = true;
                            btnConvertDoc.Enabled = true;
                            btnConvert.Enabled = true;
                        }
                        else if (txbFileName.Text.Contains(".docx"))
                        {
                            btnConvertDoc.Enabled = true;
                            btnConvert.Enabled = false;
                            btnConvertPDF.Enabled = true;
                            btnConvertTxt.Enabled = true;
                        }
                        else if (txbFileName.Text.Contains(".txt"))
                        {
                            btnConvertTxt.Enabled = false;
                            btnConvertDoc.Enabled = true;
                            btnConvert.Enabled = true;
                            btnConvertPDF.Enabled = true;
                        }
                        else
                        {
                            btnConvertTxt.Enabled = true;
                            btnConvertDoc.Enabled = false;
                            btnConvert.Enabled = true;
                            btnConvertPDF.Enabled = true;
                        }

                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }
        public static string ip;
        public static int port;
        void XulyButton(object sender, EventArgs e,string type)
        {
            progress = 1;
            myProgressBar.Value = 0;
            if (luot == 0)
            {
                ip = txbIP.Text;
                port = Convert.ToInt32(txbPort.Text);
                client = new Client(txbIP.Text, Convert.ToInt32(txbPort.Text));
                convertType = type;
                backgroundWorker1.RunWorkerAsync();
            }
            else if (luot > 0)
            {
                if (ip.Equals(txbIP.Text) && port == Convert.ToInt32(txbPort.Text))
                {
                    convertType = type;
                    backgroundWorker1.RunWorkerAsync();
                }
                else
                {
                    client.closeSocket();
                    ip = txbIP.Text;
                    port = Convert.ToInt32(txbPort.Text);
                    client = new Client(txbIP.Text, Convert.ToInt32(txbPort.Text));
                    convertType = type;
                    backgroundWorker1.RunWorkerAsync();
                }
            }
        }
        private void btnConvert_Click(object sender, EventArgs e)
        {
            
            XulyButton(sender,  e,"docx");
        }

        private void btnConvertDoc_Click(object sender, EventArgs e)
        {
            XulyButton(sender, e, "doc");

        }

        private void btnConvertTxt_Click(object sender, EventArgs e)
        {
            XulyButton(sender, e, "txt");

        }

        private void btnConvertPDF_Click(object sender, EventArgs e)
        {
            XulyButton(sender, e, "pdf");

        }


    }
}
