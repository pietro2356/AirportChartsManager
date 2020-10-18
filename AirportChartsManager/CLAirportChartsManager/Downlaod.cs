using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace CLAirportChartsManager
{
    public class Downlaod
    {
        private static string url = "https://charts.avbot.in/";

        public Downlaod() { }

        public static string DownloadFile(string ICAO, string name)
        {
            try
            {
                string uri = url + ICAO + ".pdf";
                string fileName = ICAO + " - " + name + ".pdf";
                WebClient webClient = new WebClient();
                webClient.DownloadFile(new Uri(uri), fileName);
                return fileName;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}
