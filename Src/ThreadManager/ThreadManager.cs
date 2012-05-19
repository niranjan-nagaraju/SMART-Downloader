using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Threading;
using SmartDownloader.Downloader;
using SmartDownloader.GUI;
using System.Windows.Forms;

namespace SmartDownloader
{
    public class ThreadManager
    {
        private static ArrayList ThreadsToDownloaderTable = new ArrayList();

        private ThreadManager()
        {
        }


        public static ArrayList ThreadsAndDownloaders
        {
            get
            {
                return ThreadsToDownloaderTable;
            }
        }
        public static ThreadsAndDownloader download(string url)
        {
            ControlledDownloader downloader = new ControlledDownloader(url);

            return startDownload(downloader);
        }

        public static ThreadsAndDownloader download(string url, string completeSaveFile)
        {
            ControlledDownloader downloader = new ControlledDownloader(url, completeSaveFile);

            return startDownload(downloader);

        }

        public static ThreadsAndDownloader download(string url, string saveFileLocation, string saveFileName)
        {
            ControlledDownloader downloader = new ControlledDownloader(url, (saveFileLocation + saveFileName));
            
            return startDownload(downloader);

        }

        

        private static ThreadsAndDownloader startDownload(ControlledDownloader downloader)
        {
            Thread DMThread = new Thread(new ThreadStart(downloader.download));
            DMThread.IsBackground = true;

            ThreadsAndDownloader threadAndDownloader = new ThreadsAndDownloader(
                downloader, DMThread);

            ThreadsToDownloaderTable.Add(threadAndDownloader);

            DMThread.Start();

            
            return threadAndDownloader;
        }

        public static void pause(ThreadsAndDownloader threadAndDownloader)
        {
            threadAndDownloader.DownloaderThread.Suspend();
            //updateProgress(threadAndDownloader);
            threadAndDownloader.Downloader.downloadstate = DownloadStates.paused;

        }

        public static void resume(ThreadsAndDownloader threadAndDownloader)
        {
            threadAndDownloader.DownloaderThread.Resume();
            //updateProgress(threadAndDownloader);
            threadAndDownloader.Downloader.downloadstate = DownloadStates.running;
        }


        public static void stop(ThreadsAndDownloader threadAndDownloader)
        {
            threadAndDownloader.DownloaderThread.Abort();
            threadAndDownloader.Downloader.downloadstate = DownloadStates.stopped;
        }

        public static void open(ThreadsAndDownloader threadAndDownloader)
        {

            threadAndDownloader.Downloader.open();
        }

    }
}
