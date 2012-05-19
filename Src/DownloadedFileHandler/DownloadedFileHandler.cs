using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;
using System.IO;
using Microsoft.Win32;
using System.Windows.Forms;



namespace SmartDownloader.FileHandler
{
    public class DownloadedFileHandler
    {

        public string getFileNameFromUrl(string url)
        {
            int pos = url.LastIndexOf("/");
            string fileName = url.Substring(pos + 1, url.Length - pos - 1);

            return fileName;
        }

        
        public void open(string fileName)
        {
            if (File.Exists(fileName))
            {
                Process.Start(fileName);
            }
            else
            {
                MessageBox.Show("File has been moved or deleted", "File Error!");
            }
            
        }

        public void save(string fileName, Stream responseStream)
        {
            
            FileStream fStream = new FileStream(fileName,FileMode.Append);
            byte[] buf = new byte[1024];
            int count = 0;

            do
            {
                count = responseStream.Read(buf, 0, buf.Length);

                if (count != 0)
                {
                    fStream.Write(buf, 0, count);
                }
            } while (count > 0);

            fStream.Close();
  
        }
  
    }
}
