using System;
using CLAirportChartsManager;

namespace CAAirportChartsManager
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Inserisci l'ICAO: ");
            string ICAO = Console.ReadLine();
            Console.Write("Inserisci il nome del file: ");
            string nome = Console.ReadLine();

            Console.WriteLine(Downlaod.DownloadFile(ICAO, nome));
        }
    }
}
