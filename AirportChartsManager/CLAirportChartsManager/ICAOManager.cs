using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.IO;

namespace CLAirportChartsManager
{
    class ICAOManager
    {
        public ICAOManager() { throw new NotImplementedException(); }

        async public static void Main()
        {
            throw new NotImplementedException();
            using (FileStream fs = File.OpenRead("airports.json"))
            {
                var airport = await JsonSerializer.DeserializeAsync<Airport>(fs);
            }
        }
    }
}
