using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Collections;


using SmartDownloader;
using SmartDownloader.Downloader;
using SmartDownloader.FileHandler;
using SmartDownloader.StatisticsHandler;
using SmartDownloader.ZipPreviewer;
using SmartDownloader.Xml;
using SmartDownloader.Uploader;
using SmartDownloader.MediaPreviewer;
using SmartDownloader.Encryption;
using SmartDownloader.Scheduler;
using SmartDownloader.FTPDownloader;




namespace SmartDownloader.GUI
{
    public partial class SmartDownloaderGUI : Form
    {
        ThreadsAndDownloader threadAndDownloader;
        ArrayList progressPanelsList = new ArrayList();
        int panelsCount = 0;
        public string[] Args;

        System.Threading.Timer timer;
        TimerCallback timerCB;



        public SmartDownloaderGUI()
        {
            InitializeComponent();
        }

        public SmartDownloaderGUI(string url)
        {
            InitializeComponent();

            URLTextBox.Text = url;
            
        }

        public static void updateProgress(object target)
        {
            ArrayList panelsList = (ArrayList)target;

           // MessageBox.Show("Hello");

            
            foreach (ProgressBarPanel pgPanel in panelsList )
            {
            
                ThreadsAndDownloader thd = DownloadersAndPanels.getDownloaderThread(pgPanel.progressPanel);

                //wait till response is recvd from the server
                if (thd.Downloader.ContentLength != 0)
                {
                    if (thd.Downloader.downloadstate == DownloadStates.completed)
                    {
                        pgPanel.openLinkLbl.Enabled = true;
                    }
                    pgPanel.progressBar.Value = (int)((((float)thd.Downloader.BytesDownloaded) / ((float)thd.Downloader.ContentLength)) * 100.0);
                    pgPanel.infoLabel.Text = thd.Downloader.Url + " : " + thd.Downloader.BytesDownloaded + " of " +
                        thd.Downloader.ContentLength;
            
                    pgPanel.progressBar.Invalidate();
                }
                
            }
            
            
        }

        private void intializeTimer()
        {
            timerCB = new TimerCallback(updateProgress);

            timer = new System.Threading.Timer(timerCB, progressPanelsList, 0, 1000);
        }

        
        private void StartDwnldBtn_Click(object sender, EventArgs e)
        {
            
            try
            {
                if (SavetxtBox.Text != "")
                {
                    threadAndDownloader = ThreadManager.download(URLTextBox.Text, SavetxtBox.Text);
                }
                else
                {
                    threadAndDownloader = ThreadManager.download(URLTextBox.Text);
                }

                //Associate Panel with Downloader
                DownloaderThreadAndProgressPanel downloaderAndPanel = new DownloaderThreadAndProgressPanel();
                ProgressBarPanel pgPanel = new ProgressBarPanel(panelsCount);
                panelsCount++;
                pgPanel.infoLabel.Text += URLTextBox.Text;

                progressPanelsList.Add(pgPanel);
                downloaderAndPanel.threadAndDownloader = this.threadAndDownloader;
                downloaderAndPanel.pgPanel = pgPanel;

                //comment out later
         //       pgPanel.progressBar.Value = 70;
                //Never forget or u shalt be damned!

                DownloadersAndPanels.downloadersAndPanels.Add(downloaderAndPanel);

                //add panel to mainform
                DownloadQueuePanel.Controls.Add(pgPanel.progressPanel);

                // Display Status bar message
                setStatusMessage("Download Started : " + URLTextBox.Text);

                this.intializeTimer();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n" + ex.StackTrace);
            }

             
        }

        public void setStatusMessage(string p)
        {
            StatusLabel.Text = p;
        }

        private void URLTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void pause()
        {
            int pausedCount = 0;
            foreach (ProgressBarPanel pgPanel in progressPanelsList)
            {
                if (pgPanel.selectThreadChkBox.Checked == true)
                {
                    pausedCount++;

                    threadAndDownloader = DownloadersAndPanels.getDownloaderThread(pgPanel.progressPanel);

                    ThreadManager.pause(threadAndDownloader);
                    MessageBox.Show("Paused : " + threadAndDownloader.Downloader.Url + " " + threadAndDownloader.Downloader.BytesDownloaded);
                    //MessageBox.Show("Paused : " + threadAndDownloader.Downloader.Url + " " + threadAndDownloader.Downloader.BytesDownloaded);
                    // MessageBox.Show("Hello");
                }
            }
            //ThreadManager.pause(threadAndDownloader);
            setStatusMessage("Download(s) Paused : " + pausedCount);
            //MessageBox.Show("OOps");
        }

        private void resume()
        {
            //statusLbl.Text = "Download Resumed";
            //ThreadManager.resume(threadAndDownloader);
            //setStatusMessage("Download Resumed : " + URLTextBox.Text);


            int resumedCount = 0;
            foreach (ProgressBarPanel pgPanel in progressPanelsList)
            {
                if (pgPanel.selectThreadChkBox.Checked == true)
                {
                    resumedCount++;

                    threadAndDownloader = DownloadersAndPanels.getDownloaderThread(pgPanel.progressPanel);

                    ThreadManager.resume(threadAndDownloader);
                    MessageBox.Show("Resumed : " + threadAndDownloader.Downloader.Url + " " + threadAndDownloader.Downloader.BytesDownloaded);
                    //MessageBox.Show("Paused : " + threadAndDownloader.Downloader.Url + " " + threadAndDownloader.Downloader.BytesDownloaded);
                    // MessageBox.Show("Hello");
                }
            }
            //ThreadManager.pause(threadAndDownloader);
            setStatusMessage("Download(s) Resumed : " + resumedCount);
            //MessageBox.Show("OOps");


        }

        private void stop()
        {
            int stoppedCount = 0;
            foreach (ProgressBarPanel pgPanel in progressPanelsList)
            {
                if (pgPanel.selectThreadChkBox.Checked == true)
                {
                    stoppedCount++;

                    threadAndDownloader = DownloadersAndPanels.getDownloaderThread(pgPanel.progressPanel);

                    ThreadManager.stop(threadAndDownloader);
                    MessageBox.Show("Stopped : " + threadAndDownloader.Downloader.Url + " " + threadAndDownloader.Downloader.BytesDownloaded);
                    //MessageBox.Show("Paused : " + threadAndDownloader.Downloader.Url + " " + threadAndDownloader.Downloader.BytesDownloaded);
                    // MessageBox.Show("Hello");
                }
            }
            //ThreadManager.pause(threadAndDownloader);
            setStatusMessage("Download(s) Stopped : " + stoppedCount);
            //MessageBox.Show("OOps");
        }

        private void schedule()
        {
            SchedulerForm form;
            if (SavetxtBox.Text == "")
                form = new SchedulerForm(URLTextBox.Text);
            else
                form = new SchedulerForm(URLTextBox.Text, SavetxtBox.Text);
            form.Show();
        }

        private void PauseBtn_Click(object sender, EventArgs e)
        {
            this.pause();
            
        }

        

        private void SmartDownloaderGUI_Load(object sender, EventArgs e)
        {
            

            //for (int i = 0; i < 5; i++)
            //{
            //    ProgressBarPanel pgPanel = new ProgressBarPanel(i);
            //    pgPanel.progressPanel.ResumeLayout(false);
            //    progressPanelsList.Add(pgPanel);
            //    DownloadQueuePanel.Controls.Add(pgPanel.progressPanel);
            //}
            
            //DownloadQueuePanel.Show();
        }

        private void ResumeBtn_Click(object sender, EventArgs e)
        {
            this.resume();

        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveDialog = new SaveFileDialog();

            DownloadedFileHandler dfh = new DownloadedFileHandler();
            saveDialog.FileName = dfh.getFileNameFromUrl(URLTextBox.Text);
            saveDialog.Filter = "All files(*.*)|*.*";
           
            saveDialog.ShowDialog();
            SavetxtBox.Text = saveDialog.FileName;
        }

        private void showDownloadStats()
        {
            DownloadStatsForm dwnldStatsForm = new DownloadStatsForm();
            dwnldStatsForm.Show();
        }

        
        private void encryptToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFileEncryptDecrypt frm = new frmFileEncryptDecrypt(0);
            frm.Show();

            
        }

        private void downloadQueueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                DownloadQueueForm downloadQueue = new DownloadQueueForm();

                downloadQueue.Show();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " " + ex.StackTrace, "Exception");
            }

        }

        private void validateXMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            XMLValidatorForm validatorForm = new XMLValidatorForm();
            validatorForm.Show();

        }

        private void statisticsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.showDownloadStats();
        }

        private void zipPreviewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ZipPreviewer.ZipPreviewer zipPreviewer = new ZipPreviewer.ZipPreviewer();
            zipPreviewer.Show();
        }

        private void uploadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UploadForm uploadForm = new UploadForm();
            uploadForm.Show();

        }

        private void mediaPreviewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EnterUrl mediaUrlForm = new EnterUrl();
            mediaUrlForm.Show();

        }

        private void decryptToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFileEncryptDecrypt frm = new frmFileEncryptDecrypt(1);
            frm.Show();
        }

        private void Schedulebutton_Click(object sender, EventArgs e)
        {
            this.schedule();
        }

        private void priv_btn_Click(object sender, EventArgs e)
        {
            Uri url = new Uri(URLTextBox.Text);
            string fileName = url.LocalPath;
            ZipPreviewer.ZipPreviewer zip_preview;
            MediaPreviewer.MediaPreviewer media_preview;
            if (fileName.EndsWith(".zip", StringComparison.OrdinalIgnoreCase))
            {
                zip_preview = new ZipPreviewer.ZipPreviewer(url.ToString());
                zip_preview.Show();
            }
            else if (MediaPreviewer.MediaPreviewer.isMediaFile(fileName))
            {
                DownloaderWithRanges dm = new DownloaderWithRanges(url.ToString());
                ResponseRecord record = dm.fetchFile(0, 1024 * 1024);



                String tmpFileName = Application.StartupPath + "/tmp/" + url.LocalPath;
                DownloadedFileHandler dfh = new DownloadedFileHandler();
                dfh.save(tmpFileName, record.ResponseStream);

                Thread.Sleep(300);
                media_preview = new MediaPreviewer.MediaPreviewer(tmpFileName);
                media_preview.Show();
            }
            else
            {
                setStatusMessage("Preview is not available for" + url);
            }

        }

        private void aboutUsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutUs form = new AboutUs();
            form.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AllLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            foreach (ProgressBarPanel pgPanel in progressPanelsList)
            {
                pgPanel.selectThreadChkBox.Checked = true;
            }
            
        }

        private void NoneLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            foreach (ProgressBarPanel pgPanel in progressPanelsList)
            {
                pgPanel.selectThreadChkBox.Checked = false;
            }
        }

        private void UnDockbutton_Click(object sender, EventArgs e)
        {
            DownloadQueueForm downloadQueue = new DownloadQueueForm();
            downloadQueue.Show();

        }

        private void Stopbutton_Click(object sender, EventArgs e)
        {
            this.stop();
           
        }

      

        private void schedulerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SchedulerForm form = new SchedulerForm();
            form.Show();
        }

        public delegate void ProcessParametersDelegate(object sender, string[] args);
        public void ProcessParameters(object sender, string[] args)
        {
            // The form has loaded, and initialization will have been be done.
            // Add the command-line arguments to our textbox, just to confirm that
            // it reached here.
            if (args != null && args.Length != 0)
            {

                try
                {
                    threadAndDownloader = ThreadManager.download(args[0]);
                    setStatusMessage("Download Started : " + args[0]);
                    //updateListBox();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + "\n" + ex.StackTrace);
                }

            }
        }

        private void fTPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FTPClientUI ftpc = new FTPClientUI();
            ftpc.Show();
        }

        private void pauseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.pause();
        }

        private void resumeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.resume();
        }

        private void stopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.stop();
        }

        private void schedulerToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.schedule();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        


    }
}