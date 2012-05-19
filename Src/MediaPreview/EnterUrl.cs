using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.Threading;

using SmartDownloader.Downloader;
using SmartDownloader.FileHandler;

namespace SmartDownloader.MediaPreviewer
{
    public partial class EnterUrl : System.Windows.Forms.Form
    {
        public EnterUrl()
        {
            InitializeComponent();
        }

        private void PreviewButton_Click(object sender, EventArgs e)
        {
            
            if (UrlTextBox.Text != "")
            {
                UrlTextBox.ReadOnly = true;
                DownloaderWithRanges dm = new DownloaderWithRanges(UrlTextBox.Text);
                ResponseRecord record = dm.fetchFile(0, 1024 * 1024);
                Uri url = new Uri(UrlTextBox.Text);


                String tmpFileName = Application.StartupPath+ "/tmp/" + url.LocalPath;
                DownloadedFileHandler dfh = new DownloadedFileHandler();
                dfh.save(tmpFileName, record.ResponseStream);
               
                UrlTextBox.ReadOnly = true;
                
                
                this.Close();
                Thread.Sleep(300);
                MediaPreviewer previewer = new MediaPreviewer(tmpFileName);
                previewer.Show();
                
             }
        }
    }
}
