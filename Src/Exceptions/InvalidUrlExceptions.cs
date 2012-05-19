using System;
using System.Collections.Generic;
using System.Text;


namespace SmartDownloader.Exceptions
{
    public class InvalidUrlException : System.ApplicationException
    {
        public InvalidUrlException()
        {
        }

        public InvalidUrlException(string msg)
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
