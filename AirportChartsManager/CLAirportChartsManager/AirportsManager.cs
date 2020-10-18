using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;
using CsvHelper;
using System.IO;
using System.Runtime.InteropServices;
using System.Collections.Specialized;

namespace CLAirportChartsManager
{
    public class AirportsManager
    {
        private List<Airport> airports = new List<Airport>();
        private string path;

        public AirportsManager(string dataPath) 
        {
            this.path = dataPath;
            if (!loadData())
            {
                throw new DataNotLoadException("Il caricamento dei dati è fallito!");
            }
        }

        #region LOAD

        /// <summary>
        /// Funzione di caricamento dati!
        /// </summary>
        public bool loadData()
        {
            try
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
                }
                sr.Close();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        #endregion LOAD

        #region SEARCH

        /// <summary>
        /// Funzione generica per il DB.
        /// </summary>
        /// <returns>Ritorna tutta la lista degli aeroporti.</returns>
        public List<Airport> getAirports()
        {
            return airports;
        }


        /// <summary>
        /// Funzione di ricerca.
        /// </summary>
        /// <param name="ICAO">Codice ICAO dell'aereoporto da cercare.</param>
        /// <returns>L'oggetto Airport contente i dati dell'aereoporto.</returns>
        public Airport searchAirportICAO(string ICAO)
        {

            foreach (Airport item in airports)
            {
                if (item.ident == ICAO)
                {
                    return item;
                }
                continue;
            }
            throw new AirportNotFoundException(ICAO);
        }

        /// <summary>
        /// Funzione di ricerca.
        /// </summary>
        /// <param name="name">Nome dell'aereoporto da cercare</param>
        /// <returns>L'oggetto Airport contente i dati dell'aereoporto.</returns>
        public Airport searchAirportName(string name)
        {
            foreach (Airport item in airports)
            {
                if (item.name.Contains(name))
                {
                    return item;
                }
                continue;
            }
            throw new AirportNotFoundException(name);
        }


        /// <summary>
        /// Funzione di ricerca.
        /// </summary>
        /// <param name="type">Tipo di aeroporto.</param>
        /// <returns>Lista contenente gli aeroporti</returns>
        public List<Airport> getAirportType(AirportsType type)
        {
            List<Airport> list = new List<Airport>();

            foreach (Airport item in airports)
            {
                if (item.type == type.ToString())
                {
                    list.Add(item);
                }
                continue;
            }
            if (list.Count == 0) throw new AirportNotFoundException(type.ToString());
            else return list;
        }

        /// <summary>
        /// Funzione di ricerca.
        /// </summary>
        /// <param name="country">Stato</param>
        /// <returns>Lista contenente gli aeroporti</returns>
        public List<Airport> searchAirportsCountry(string country)
        {
            List<Airport> list = new List<Airport>();

            foreach (Airport item in airports)
            {
                if (item.isoCountry == country)
                {
                    list.Add(item);
                }
                continue;
            }
            if (list.Count == 0) throw new AirportNotFoundException(country);
            else return list;
        }

        #endregion SEARCH

        #region ADD-ON
        /// <summary>
        /// Funzione aggiuntiva
        /// </summary>
        /// <param name="country">Codice nazionale</param>
        /// <returns>Lista contenente l'elenco dei condici ICAO per nazione</returns>
        public List<string> getICAOcodeByCountry(string country)
        {
            List<string> list = new List<string>();

            foreach (Airport item in airports)
            {
                if (item.isoCountry == country)
                {
                    list.Add(item.ident);
                }
                continue;
            }
            if (list.Count == 0) throw new AirportNotFoundException(country);
            else return list;
        }
        #endregion ADD-ON

    }
}
