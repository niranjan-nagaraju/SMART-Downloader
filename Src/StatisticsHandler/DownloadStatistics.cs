using System;
using System.Collections.Generic;
using System.Text;
using System.Net;

namespace SmartDownloader.StatisticsHandler
{
    [Serializable]
    public class DownloadStatistics
    {
        public string fileName;
        public string url;
        public string saveLocation;
        public string completeSaveFile;
        public byte[] MD5Checksum;
        public int contentLength;
        //public WebHeaderCollection responseHeaders;


        public override string ToString()
        {
            string ReturnString = "URL : " + url + "\t\t" +
                "File Size : " + contentLength + "\t\t" +
                "File Saved In : " + (completeSaveFile) + "\t\t" +
                "MD5 Checksum : ";

            for (int i = 0; i < MD5Checksum.Length; i++)
            {
                ReturnString += MD5Checksum[i].ToString();
            }

            ReturnString += "\t";

           // ReturnString += "Response Headers : " + responseHeaders.ToString();

            return ReturnString;
        }

    }
}
