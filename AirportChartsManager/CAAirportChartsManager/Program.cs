using System;
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

            try
            {
                AirportsManager am = new AirportsManager();
                Console.WriteLine(am.searchAirport("LIDT"));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
