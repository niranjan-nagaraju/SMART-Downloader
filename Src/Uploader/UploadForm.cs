using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using SmartDownloader.FileHandler;

namespace SmartDownloader.Uploader
{
    public partial class UploadForm : Form
    {
        Uploader uploader;

        public UploadForm()
        {
            InitializeComponent();
            

        }

        private void UploadForm_Load(object sender, EventArgs e)
        {

        }

        private void BrowseButton_Click(object sender, EventArgs e)
        {
            DownloadedFileHandler dfh = new DownloadedFileHandler();

            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "All files(*.*) | *.*";

            if (UrlTextBox.Text != "")
            {
                open.FileName = dfh.getFileNameFromUrl(UrlTextBox.Text);
            }

            open.ShowDialog();
            String fileName = open.FileName;
            FiletextBox.Text = fileName;
            //UploadForm_Load(null,null);
        }

        private void UploadButton_Click(object sender, EventArgs e)
        {
            String fileName = FiletextBox.Text;
            String urlstring= UrlTextBox.Text;
            progressBar.Value = 0;
            progressBar.Minimum = 0;
            progressBar.Maximum = 100;
            progressBar.Step = 1;
            if (fileName != "" && urlstring != "")
            {
                uploader = new Uploader(urlstring, fileName);

                statusDelegate st = new statusDelegate(setStatusMessage);
                cbProgress prog = new cbProgress(onProgress);
                
                uploader.startUpload(st,prog);
                
                //this.Close();
            }
            

        }
        public void setStatusMessage(string p)
        {
            statusMessageLabel.Text = p;
        }
         
        public void onProgress()
        {
            
            progressBar.PerformStep();
            Application.DoEvents();

        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    public delegate void  statusDelegate(string p);
    public delegate void cbProgress();
}