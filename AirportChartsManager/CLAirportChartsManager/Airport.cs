using CsvHelper.Configuration;
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
        public string ident { get; set; }
        public string type { get; set; }
        public string name { get; set; }
        public int elevationFt { get; set; }
        public string continent { get; set; }
        public string isoCountry { get; set; }
        public string isoRegion { get; set; }
        public string municipality { get; set; }
        public string gpsCode { get; set; }
        public string iataCode { get; set; }
        public string localCode { get; set; }
        public string coordinates { get; set; }
    }

    public class AirportClassMap : ClassMap<Airport>
    {
        public AirportClassMap()
        {
            Map(m => m.ident).Name("ident");
            Map(m => m.type).Name("type");
            Map(m => m.name).Name("name");
            Map(m => m.elevationFt).Name("elevation_ft");
            Map(m => m.continent).Name("continent");
            Map(m => m.isoCountry).Name("iso_country");
            Map(m => m.isoRegion).Name("iso_region");
            Map(m => m.municipality).Name("municipality");
            Map(m => m.gpsCode).Name("gps_code");
            Map(m => m.iataCode).Name("iata_code");
            Map(m => m.localCode).Name("local_code");
            Map(m => m.coordinates).Name("coordinates");
        }
    }

}
