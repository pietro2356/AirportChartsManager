using System;
using System.Collections.Generic;
using CLAirportChartsManager;

namespace CAAirportChartsManager
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("Inserisci l'ICAO: ");
            //string ICAO = Console.ReadLine();
            //Console.Write("Inserisci il nome del file: ");
            //string nome = Console.ReadLine();

            //Console.WriteLine(Downlaod.DownloadChartsFile(ICAO, nome));

            AirportsManager am = new AirportsManager(@"C:\Users\pietro\source\repos\pietro2356\AirportChartsManager\AirportChartsManager\CLAirportChartsManager\ICAOData.csv");
            am.loadData("IT");
            List<Airport> lista = am.getAirports();

            foreach (Airport item in lista)
            {
                Console.WriteLine(item.ident + " - Nome: " + item.name +  " -  Coordinate: " + item.coordinates);
            }
            
        }
    }
}
