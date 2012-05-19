using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;

using SmartDownloader.Exceptions;



namespace SmartDownloader
{
    namespace Downloader
    {
        /// <summary>
        ///        Performs Basic Downloading Operations using HTTP
        /// </summary>

        [Serializable]
        public class BasicDownloader
        {
            private string url;
            

            public string Url
            {
                get
                {
                    return url;
                }
                set
                {
                    url = value;
                }
            }

            public BasicDownloader(string url)
            {
                this.url = url;
            }


            protected bool IsUrlValid
            {
                get
                {
                    bool valid = false;

                    Uri target = new Uri(url);

                    try
                    {
                        IPHostEntry ipHost = Dns.GetHostEntry(target.Host);
                        valid = true;
                    }

                    catch (SocketException se)
                    {
                        valid = false;
                    }
                  
                        return valid;
                  

                }
            }

                

            protected HttpWebRequest createRequest(string method)
            {
                // prepare the http request to fetch the required file
                
                HttpWebRequest request = (HttpWebRequest)
                    WebRequest.Create(url);
                request.Method = method;
            //    request.AllowAutoRedirect = true;
                //request.Proxy = Iw
                
                               

                return request;
            }


            protected HttpWebResponse getResponse(HttpWebRequest request)
            {
                // execute the request

                
                    HttpWebResponse response = (HttpWebResponse)
                        request.GetResponse();


                    return response;
                
            }

            

            protected ResponseRecord populateResponseRecord(HttpWebResponse response)
            {
                Stream responseStream = response.GetResponseStream();
                

                ResponseRecord responseRecord = new ResponseRecord();
                responseRecord.ResponseHeaders = response.Headers;
                responseRecord.ResponseStream = responseStream;

                return responseRecord;
            }


            public ResponseRecord fetchFile()
            {
                if (!this.IsUrlValid)
                {
                    throw new InvalidUrlException("The Url is Invalid");
                }
                HttpWebRequest request = createRequest("GET");
                
                HttpWebResponse response = getResponse(request);

                //startScan(response);

                return populateResponseRecord(response);
            }

         
            public ResponseRecord fetchOnlyHeaders()
            {
                
                HttpWebRequest request = createRequest("HEAD");
                
                HttpWebResponse response = getResponse(request);

                return populateResponseRecord(response);



            }

            
        }
    }
}