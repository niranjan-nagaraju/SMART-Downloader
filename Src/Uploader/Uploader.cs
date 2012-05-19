using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.IO;
using System.Windows.Forms;
using SmartDownloader.Downloader;
using SmartDownloader.Exceptions;

namespace SmartDownloader.Uploader
{
    public class Uploader : BasicDownloader
    {
        
        string fileName;


        public Uploader()
            : base(null)
        {
        }

        public Uploader(string url, string fileName)
            : base(url)
        {
            this.fileName = fileName;
        }

        public void startUpload(statusDelegate setstatus, cbProgress onprogress)
        {
            if (!this.IsUrlValid)
            {
                setstatus("The entered Url is Invalid");
            }


             HttpWebRequest request = this.createRequest("PUT");

             ((HttpWebRequest)request).AllowWriteStreamBuffering = true;

             request.ContentLength = (new FileInfo(fileName)).Length;
             request.ContentType = "application/octet-stream";

             using (FileStream inFile = new FileStream(fileName, FileMode.Open))
             {
                 byte[] inBytes = new byte[inFile.Length];
                 inFile.Read(inBytes, 0, inBytes.Length);
                 MemoryStream temp = new MemoryStream();
                 temp.Write(inBytes, 0, inBytes.Length);


                 using (Stream s = request.GetRequestStream())
                     temp.WriteTo(s);
                 temp.Close();
             }
             try
             {
                 HttpWebResponse response = getResponse(request);
             }
             catch
             {
                 setstatus("Unable to upload the file "+fileName);
                 return;
             }

             for (int i = 0; i < 100; i++)
                     onprogress();
                 
             
             setstatus("Upload Complete : " + this.fileName + "  uploaded to " + this.Url);

        }

        

                
    }
}
