using System.Threading;
using SmartDownloader.Downloader;

namespace SmartDownloader
{
    public struct ThreadsAndDownloader
    {
        private ControlledDownloader downloader;
        private Thread downloaderThread;

        public ThreadsAndDownloader(ControlledDownloader downloader, Thread thread)
        {
            this.downloader = downloader;
            this.downloaderThread = thread;
        }

        public Thread DownloaderThread
        {
            get
            {
                return downloaderThread;
            }
        }

        public override string ToString()
        {
            return downloader.Url + "\t" + downloader.BytesDownloaded + " of " + downloader.ContentLength + " status : " + 
                downloader.downloadstate;
            
        }

        public ControlledDownloader Downloader
        {
            get
            {
                return downloader;
            }
        }


    }
}