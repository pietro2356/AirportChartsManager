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
            am.loadData();
            Airport a = am.searchAirport("LIDDFT");

            Console.WriteLine(a.ident);
            Console.WriteLine(a.name);
            Console.WriteLine(a.type);
        }
    }
}
