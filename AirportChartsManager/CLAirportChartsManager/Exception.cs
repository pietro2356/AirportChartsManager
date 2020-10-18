using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLAirportChartsManager
{
    [Serializable]
    public class DataNotLoadException : Exception
    {
        public DataNotLoadException()
        {
        }

        public DataNotLoadException(string message) : base(message)
        {
        }

        public DataNotLoadException(string message, Exception inner) : base(message, inner)
        {
        }
    }

    [Serializable]
    public class AirportNotFoundException : Exception
    {
        public string ICAO;
        public AirportNotFoundException()
        {
        }

        public AirportNotFoundException(string message) : base(message)
        {
        }

        public AirportNotFoundException(string message, Exception inner) : base(message, inner)
        {
        }
    }
}
