using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Net;
using System.Net.Sockets;

namespace SmartDownloader.Scheduler
{
    public class Scheduler
    {
        private string url;
        private string completeSaveFileName;

        public Scheduler(string url, string completeSaveFileName){
            this.url=url;
            this.completeSaveFileName= completeSaveFileName ;
        }
        public Scheduler(string url): this(url,""){}

        public bool scheduleDownload(DateTime date, DateTime time,DateTime now)
        {
            
            DateTime givenTime = new DateTime(date.Year,date.Month,date.Day,
                                               time.Hour,time.Minute,time.Second);
                        
            TimerCallback timeCB = new TimerCallback(startDownload);

            TimeSpan tsp;
            try{
               tsp= givenTime.Subtract(now);
            }
            catch(Exception e){
                Console.WriteLine(e.StackTrace);
                return false;
            }

            Timer t = new Timer(timeCB, null, tsp.Seconds, Timeout.Infinite);
            

            return true;
            

        }
        
        


        private void startDownload(object state)
        {
            try
            {
                ThreadsAndDownloader threadAndDownloader;
                if(completeSaveFileName=="")
                    threadAndDownloader = ThreadManager.download(url);
                else
                    threadAndDownloader = ThreadManager.download(url,completeSaveFileName);
                              
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + "\n" + ex.StackTrace);
            }
        }
    }
}
