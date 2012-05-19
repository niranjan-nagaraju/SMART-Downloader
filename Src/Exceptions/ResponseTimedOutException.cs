using System;
using System.Collections.Generic;
using System.Text;

namespace SmartDownloader.Exceptions
{
    public class ResponseTimedOutException : System.ApplicationException
    {
        public ResponseTimedOutException()
        {
        }

        public ResponseTimedOutException(string msg)
            : base(msg)
        {
        }


        public override string Message
        {
            get
            {
                return base.Message;
            }
        }
    }
}
