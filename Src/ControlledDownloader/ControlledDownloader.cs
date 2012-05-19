using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.IO;
using System.Threading;
using System.Windows.Forms;

using SmartDownloader.Downloader;
using SmartDownloader.FileHandler;
using SmartDownloader.StatisticsHandler;




namespace SmartDownloader.Downloader
{
    [Serializable]
    public class ControlledDownloader : DownloaderWithRanges
    {
        private int bytesDownloaded;
        private ResponseRecord responseHeaders;
        private string fileSaveLocation = "./Downloads/";
        private string saveFile;
        private string completeFileName;
        private bool openDownloadedFile = true;


        public DownloadStates downloadstate;
       
        

        public ControlledDownloader()
            : base(null)
        {
            //used only for serialization purposes
        }

        

        public ControlledDownloader(string url)
            : base(url)
        {
            //fetch the file to a temporary location and open it
            DownloadedFileHandler dfh = new DownloadedFileHandler();
            this.saveFile = dfh.getFileNameFromUrl(url);
            this.completeFileName = fileSaveLocation + saveFile;

            this.openDownloadedFile = true;
        }

        
        
       

        public ControlledDownloader(string url, string completeSaveFileName)
            : base(url)

        {
            //fetch the file and save it to the specified location
            // with filename and location as specified
         

            this.completeFileName = completeSaveFileName;
            this.openDownloadedFile = false;
            

        }


        public ControlledDownloader(string url, string fileSaveLocation, string fileName) 
            : base(url)
        {
            // fetch the file and save it to the specified location
            // with filename specified by user

            this.fileSaveLocation = fileSaveLocation;
            this.openDownloadedFile = false;

            this.saveFile = fileName;

            if (fileName == null)
            {
                // if filename is not specified, use the filename as is from thr url
                DownloadedFileHandler dfh = new DownloadedFileHandler();
                this.saveFile = dfh.getFileNameFromUrl(url);
            }
            this.completeFileName = fileSaveLocation + saveFile;
        }




        public string SaveFileName
        {
            get
            {
                return saveFile;
            }

            set
            {
                saveFile = value;
            }
        }

        public string FileSaveLocation
        {
            get
            {
                return fileSaveLocation;
            }

            set
            {
                fileSaveLocation = value;
            }
        }

        public string CompleteSaveFileName
        {
            get
            {
                return completeFileName;
            }

            set
            {
               this.completeFileName = value;
            }
        }

        public bool OpenDownloadedFile
        {
            get
            {
                return openDownloadedFile;
            }

            set
            {
                openDownloadedFile = value;
            }
        }

        public int BytesDownloaded
        {
            get
            {
                return bytesDownloaded;
            }

            set
            {
                bytesDownloaded = value;
            }
        }

        public bool IsCompleted
        {
            get
            {
                return (ContentLength - bytesDownloaded) == 0;
            }
        }


        public int ContentLength
        {
            get
            {
                if (responseHeaders != null)
                {
                    return int.Parse(responseHeaders["Content-Length"]);
                }
                else
                    return 0;
            }

           
        }


        public  WebHeaderCollection ResponseHeaders
        {
            get
            {
                return responseHeaders.ResponseHeaders;
            }

        }



        public void download()
        {
            this.responseHeaders = fetchOnlyHeaders();
            this.downloadstate = DownloadStates.waiting;

            for (int i = 0; i < ContentLength; i += 1024)
            {
                int toBytes = (i + 1023) < ContentLength ? i + 1023 : ContentLength - 1;

                ResponseRecord responseRecord = fetchFile(i, toBytes);
                this.downloadstate = DownloadStates.running;

                bytesDownloaded += (toBytes-i < 1023) ? toBytes - i + 1 : 1024;

                DownloadedFileHandler dfh = new DownloadedFileHandler();
                
                dfh.save(completeFileName, responseRecord.ResponseStream);

             }

             if (openDownloadedFile == true)
                 this.open();

             this.downloadstate = DownloadStates.completed;
             //MessageBox.Show(this.Url + " Finished Downloading to " + completeFileName);
            // write to stats file after finishing downloading

            
             StatisticsHandler.StatisticsHandler.appendToDownloadedStatistics(this);
            

             //requestScan();


            
        }

        public void open()
        {
            DownloadedFileHandler dfh = new DownloadedFileHandler();

            
            dfh.open(completeFileName);

            
        }




    }
}
