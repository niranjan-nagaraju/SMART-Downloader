using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.IO;
using System.Windows.Forms;

using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

using SmartDownloader.Downloader;
using SmartDownloader.MD5Checksum;

namespace SmartDownloader.StatisticsHandler
{
    public class StatisticsHandler
    {
        private static ArrayList downloadedStatistics = new ArrayList();

        public static void appendToDownloadedStatistics(ControlledDownloader Downloader)
        {
            DownloadStatistics downloadStats = new DownloadStatistics();
            downloadStats.contentLength = Downloader.ContentLength;
            downloadStats.fileName = Downloader.SaveFileName;
            downloadStats.saveLocation = Downloader.FileSaveLocation;
            downloadStats.completeSaveFile = Downloader.CompleteSaveFileName;
            downloadStats.url = Downloader.Url;
           // downloadStats.responseHeaders = Downloader.ResponseHeaders;

            MD5Calculator md5Calculator = new MD5Calculator();
            downloadStats.MD5Checksum = md5Calculator.computeHash(Downloader.CompleteSaveFileName);

            appendToDownloadedStatistics(downloadStats);


        }



        public static void appendToDownloadedStatistics(DownloadStatistics dwnldStats)
        {
            retrieveStatistics();
            downloadedStatistics.Add(dwnldStats);
            Stream fileStream = File.Open(Application.StartupPath + "/DownloadStats/Downloads.bin", FileMode.Create, FileAccess.ReadWrite);

            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(fileStream, downloadedStatistics);
            fileStream.Close();
        }


        public static ArrayList retrieveStatistics()
        {

            Stream fileStream = null;
            BinaryFormatter formatter = new BinaryFormatter();

            DirectoryInfo di = new DirectoryInfo(Application.StartupPath);

            //MessageBox.Show(di.FullName);

            if (File.Exists(Application.StartupPath + "/DownloadStats/Downloads.bin"))
            {
                fileStream = File.Open(Application.StartupPath + "/DownloadStats/Downloads.bin", FileMode.Open, FileAccess.ReadWrite);

                downloadedStatistics = (ArrayList)formatter.Deserialize(fileStream);

                fileStream.Close();

            }

            return downloadedStatistics;

        }


        public static void writeStatsToFile(ArrayList downloadStats)
        {
            Stream fileStream = null;
            BinaryFormatter formatter = new BinaryFormatter();

            DirectoryInfo di = new DirectoryInfo(Application.StartupPath);

            if (File.Exists(Application.StartupPath + "/DownloadStats/Downloads.bin"))
            {
                fileStream = File.Open(Application.StartupPath + "/DownloadStats/Downloads.bin", FileMode.Open, FileAccess.Write);

                formatter.Serialize(fileStream, downloadStats);

                fileStream.Close();

            }

            
        }
        
    }
}
