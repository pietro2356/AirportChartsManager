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
        private string path;

        public AirportsManager(string dataPath) 
        {
            this.path = dataPath;
        }

        public bool loadData(string country)
        {
            string line;

            FileStream fs = new FileStream(path, FileMode.Open);
            StreamReader sr = new StreamReader(fs);

            string headerLine = sr.ReadLine();

            while ((line = sr.ReadLine()) != null)
            {
                string[] d = line.Split(',');
                
                if (d.Length == 13)
                {
                    string coo = String.Concat(d[11], d[12]);
                    airports.Add(new Airport(d[0], d[1], d[2], d[3], d[4], d[5], d[6], d[7], d[8], d[9], d[10], coo));
                }
                //line = sr.ReadLine();
            }
            sr.Close();
            return true;

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
            return new Airport();
        }
    }
}
