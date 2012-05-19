using System;
using System.Collections.Generic;
using System.Text;

namespace SmartDownloader.Downloader
{
   public enum DownloadStates
    {
        waiting,
        running,
        paused,
        stopped,
        completed
    }
}
