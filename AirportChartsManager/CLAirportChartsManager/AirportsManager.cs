using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;
using CsvHelper;
using System.IO;

namespace CLAirportChartsManager
{
    public class AirportsManager
    {
        private List<Airport> airports = new List<Airport>();
        public AirportsManager() 
        {
            throw new NotImplementedException("Da Fixare");
            try
            {
                //FIXME: Da fixare il PATH.
                string path = @"c:\VM\ICAOData.csv";
                using (TextReader reader = File.OpenText(path))
                {
                    CsvReader csv = new CsvReader((IParser)reader);
                    csv.Configuration.Delimiter = ",";
                    csv.Configuration.MissingFieldFound = null;
                    while (csv.Read())
                    {
                        Airport Record = csv.GetRecord<Airport>();
                        airports.Add(Record);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        public List<Airport> getAirports()
        {
            return airports;
        }

        public Airport searchAirport(string ICAO)
        {
            foreach (Airport item in airports)
            {
                if (item.ident == ICAO)
                {
                    return item;
                }
                continue;
            }
            return null;
        }
    }
}
