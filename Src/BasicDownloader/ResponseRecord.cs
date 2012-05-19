using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.IO;

namespace SmartDownloader.Downloader
{
    [Serializable]
    public class ResponseRecord
    {
        private WebHeaderCollection responseHeaders;
        private Stream responseStream;

        public ResponseRecord()
        {
        }

        public WebHeaderCollection ResponseHeaders
        {
            get
            {
                return responseHeaders;
            }

            set
            {
                responseHeaders = value;
            }
        }


        public Stream ResponseStream
        {
            get
            {
                return responseStream;
            }

            set
            {
                responseStream = value;
            }
        }

        public string this[string Header]
        {
            get
            {
                return responseHeaders[Header];
            }
        }

    }
}
