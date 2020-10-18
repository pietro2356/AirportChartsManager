using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLAirportChartsManager
{
    /// <summary>
    /// Classe Airport per serializzare e deserializzare file JSON.
    /// </summary>
    public class Airport
    {
        public string icao { get; set; }
        public string iata { get; set; }
        public string name { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string country { get; set; }
        public int elevation { get; set; }
        public double lat { get; set; }
        public double lon { get; set; }
        public string tz { get; set; }
    }
}
