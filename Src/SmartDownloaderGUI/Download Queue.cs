using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;

using SmartDownloader;
using SmartDownloader.Downloader;

namespace SmartDownloader.GUI
{
    public partial class DownloadQueueForm : Form
    {
        int selectedIndex = -1;
        TimerCallback callBack;
        System.Threading.Timer timer;
        //ArrayList ThreadsAndDownloaders;

        public DownloadQueueForm()
        {
            InitializeComponent();
        }

        private  void updateListBox()
        {
            updateCB(this.DownloadQueueListBox);

            //ArrayList ThreadsAndDownloaders = ThreadManager.ThreadsAndDownloaders;
            

            //DownloadQueueListBox.Items.Clear();

            //if (ThreadsAndDownloaders.Count > 0)
            //{
            //    foreach (ThreadsAndDownloader threadAndDownloader in ThreadsAndDownloaders)
            //    {
            //        DownloadQueueListBox.Items.Add(threadAndDownloader);
            //    }
            //}
            

        
        }


        public static void updateCB(object target)
        {
            ArrayList ThreadsAndDownloaders = ThreadManager.ThreadsAndDownloaders;
            ListBox  DownloadQueueListBox = (ListBox)target;

            
            DownloadQueueListBox.Items.Clear();

            if (ThreadsAndDownloaders.Count > 0)
            {
                
                foreach (ThreadsAndDownloader threadAndDownloader in ThreadsAndDownloaders)
                {
                    DownloadQueueListBox.Items.Add(threadAndDownloader);
                }

                //DownloadQueueListBox.Invalidate();
            }
            
        }

        public void initializeTimer()
        {
            callBack = new TimerCallback(updateCB);

            timer = new System.Threading.Timer(
                callBack, DownloadQueueListBox, 0, 5000);
        }

        private void DownloadQueueForm_Load(object sender, EventArgs e)
        {

            initializeTimer();
            updateListBox();
            

        }

        private void PauseBtn_Click(object sender, EventArgs e)
        {
            selectedIndex = DownloadQueueListBox.SelectedIndex;

            if (selectedIndex < 0)
            {
                MessageBox.Show("Please Select a download Thread!");
                return;
            }
            ThreadsAndDownloader threadAndDownloader = (ThreadsAndDownloader)DownloadQueueListBox.Items[selectedIndex];
            threadAndDownloader.DownloaderThread.Suspend();
            threadAndDownloader.Downloader.downloadstate = DownloadStates.paused;

            this.updateListBox();
          }

        private void Resumebtn_Click(object sender, EventArgs e)
        {
            selectedIndex = DownloadQueueListBox.SelectedIndex;


            if (selectedIndex < 0)
            {
                MessageBox.Show("Please Select a download Thread!");
                return;
            }
            ThreadsAndDownloader threadAndDownloader = (ThreadsAndDownloader)DownloadQueueListBox.Items[selectedIndex];
            threadAndDownloader.DownloaderThread.Resume();
            threadAndDownloader.Downloader.downloadstate = DownloadStates.running;

            this.updateListBox();

            
        }

        private void Stopbtn_Click(object sender, EventArgs e)
        {
            selectedIndex = DownloadQueueListBox.SelectedIndex;


            if (selectedIndex < 0)
            {
                MessageBox.Show("Please Select a download Thread!");
                return;
            }

            ThreadsAndDownloader threadAndDownloader = (ThreadsAndDownloader)DownloadQueueListBox.Items[selectedIndex];
            threadAndDownloader.DownloaderThread.Abort();
            threadAndDownloader.Downloader.downloadstate = DownloadStates.stopped;

            this.updateListBox();
        }

        private void CleanUpButton_Click(object sender, EventArgs e)
        {

        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.updateListBox();
        }

        





    }
}