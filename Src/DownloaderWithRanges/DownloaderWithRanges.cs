using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using SmartDownloader.Downloader;

namespace SmartDownloader.Downloader
{
    [Serializable]
    public class DownloaderWithRanges : BasicDownloader
    {
        public DownloaderWithRanges(string url)
            : base(url)
        {

        }


        protected HttpWebRequest createRequest(int range, string method)
        {
            HttpWebRequest request = createRequest(method);
            request.AddRange(range);

            return request;
        }


        protected HttpWebRequest createRequest(int from, int to, string method)
        {
            HttpWebRequest request = createRequest(method);
            request.AddRange(from, to);



            return request;

        }


        public ResponseRecord fetchFile(int range)
        {
            HttpWebRequest request = createRequest(range, "GET");

            HttpWebResponse response = getResponse(request);

            

            return populateResponseRecord(response);

        }


        public ResponseRecord fetchFile(int from, int to)
        {
            HttpWebRequest request = createRequest(from, to, "GET");

            HttpWebResponse response = getResponse(request);

            return populateResponseRecord(response);


        }

    }
}
