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
        public string elevationFt { get; set; }
        public string continent { get; set; }
        public string isoCountry { get; set; }
        public string isoRegion { get; set; }
        public string municipality { get; set; }
        public string gpsCode { get; set; }
        public string iataCode { get; set; }
        public string localCode { get; set; }
        public string coordinates { get; set; }

        public Airport(string ident, string type, string name, string elevationFt, string continent, string isoCountry, string isoRegion, string municipality, string gpsCode, string iataCode, string localCode, string coordinates)
        {
            this.ident = ident;
            this.type = type;
            this.name = name;
            this.elevationFt = elevationFt;
            this.continent = continent;
            this.isoCountry = isoCountry;
            this.isoRegion = isoRegion;
            this.municipality = municipality;
            this.gpsCode = gpsCode;
            this.iataCode = iataCode;
            this.localCode = localCode;
            this.coordinates = coordinates;
        }
        public Airport() { }
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
