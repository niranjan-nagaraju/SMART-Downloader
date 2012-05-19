using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Security.Cryptography;

namespace SmartDownloader.MD5Checksum
{
    public class MD5Calculator
    {
        public byte[] computeHash(string fileName)
        {
            FileStream fs = File.OpenRead(fileName);
            MD5CryptoServiceProvider csp = new MD5CryptoServiceProvider();

            byte[] hash = csp.ComputeHash(fs);

            return hash;

        }


        public bool isEqual(string oneFile, string anotherFile)
        {
            byte[] hashOneFile = this.computeHash(oneFile);
            byte[] hashAnotherFile = this.computeHash(anotherFile);

            
            if (hashOneFile.Length != hashAnotherFile.Length)
            {
                return false;
            }

            for (int i = 0; i < hashAnotherFile.Length; i++)
            {
                if (hashAnotherFile[i] != hashOneFile[i])
                {
                    return false;
                }
            }

            return true;

        }

    }
}
