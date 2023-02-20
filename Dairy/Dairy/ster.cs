using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Dairy
{
    internal class ster
    {
        public static void save<T>(T zametki)
        {
            String json = JsonConvert.SerializeObject(zametki);
            File.WriteAllText("C:\\Users\\Эдуард\\Desktop\\Result.json", json);
        }

        public static T get<T>()
        {
            T zametki = JsonConvert.DeserializeObject<T>(File.ReadAllText("C:\\Users\\Эдуард\\Desktop\\Result.json"));
            return zametki;
        }
    }
}
