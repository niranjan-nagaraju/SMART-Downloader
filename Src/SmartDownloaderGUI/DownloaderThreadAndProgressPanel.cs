using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Collections;


using SmartDownloader.Downloader;

namespace SmartDownloader.GUI
{
    public class DownloaderThreadAndProgressPanel
    {
        public ThreadsAndDownloader threadAndDownloader;
        public ProgressBarPanel pgPanel;

        
    }


    public class DownloadersAndPanels
    {
        public static ArrayList downloadersAndPanels = new ArrayList();

        public static ThreadsAndDownloader getDownloaderThread(Panel panel)
        {
            ThreadsAndDownloader threadAndDownloader;
           
                foreach (DownloaderThreadAndProgressPanel dwnlderPanel in downloadersAndPanels)
                {
                    if(ReferenceEquals(panel, dwnlderPanel.pgPanel.progressPanel))
                    {
                        threadAndDownloader = dwnlderPanel.threadAndDownloader;
                    }
                }

                return threadAndDownloader;

                
            
        }

        public static ProgressBarPanel getPanel(ControlledDownloader downloader)
        {
            ProgressBarPanel pgPanel = null;

            foreach (DownloaderThreadAndProgressPanel dwnlderPanel in downloadersAndPanels)
            {
                if(ReferenceEquals(downloader, dwnlderPanel.threadAndDownloader.Downloader))
                {
                    pgPanel = dwnlderPanel.pgPanel;
                }
            }

            return pgPanel;
            

        }
    }
}
