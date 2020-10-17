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
        private WebClient webClient = new WebClient();
        private static string url = "https://charts.avbot.in/";
        private string ICAO = "";


        public Downlaod(string ICAO)
        {
            this.ICAO = ICAO;
        }
        public Downlaod() { }


        public void DownloadFile()
        {
            webClient.DownloadDataAsync(new Uri(url + ICAO + ".pdf"));
        }
    }
}
