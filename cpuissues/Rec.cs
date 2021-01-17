using System;
using System.IO;
using System.Net;
using System.Threading;

namespace cpuissues
{
    public class Rec
    {
        
        public Rec()
        {
            start();
        }
        private void start()
        {
            try
            {
                Thread httP_start = new Thread(httpStart);
                httP_start.Start();
                //httpStart();

            }
            catch (Exception ex)
            {

            }
        }


        private async void httpStart()
        {
            //this is URL stream from internet... you can use ANY another iptv stream if you found .....
            string url = "http://tviptv.iptv-channel.ru:8000/live/NndqUU6Xoe/mV6O7VmqLx/138.ts"; //"http://tviptv.iptv-channel.ru:8000/live/NndqUU6Xoe/mV6O7VmqLx/1.ts"; 
            

            try
            {

                // Console.WriteLine("About to open Webclient");
                WebClient client = new WebClient();

                using (Stream stream = client.OpenRead(url))
                {
                    int bytesReceived = 1316; //must be used 1316 value for our purposes
                    byte[] buffer = new byte[bytesReceived];
                    int i = 0;

                    while ((bytesReceived = stream.Read(buffer, 0, buffer.Length)) != 0)
                    {
                        i = i + 1;
                        Console.WriteLine(Convert.ToString(i));
                        //Thread.Sleep(100); //DO NOT USE THIS ... ITS NOT SOLUTION we need nonstop getting data...!
                    }

                   
                }
            }
            catch (Exception e)
            {

            }
        }
    }
}
