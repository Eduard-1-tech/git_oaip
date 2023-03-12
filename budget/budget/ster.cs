using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace budget
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

        public static void Save(dannie dannie)
        {
            List<dannie> allDannie =Read() ;
            allDannie.Add(dannie);
            string serial= JsonConvert.SerializeObject(allDannie);
            File.WriteAllText("C:\\Users\\Эдуард\\Desktop\\Result.json",serial);
        }
        public static List<dannie> Read()
        {
            string json = File.ReadAllText("C:\\Users\\Эдуард\\Desktop\\Result.json");
            List<dannie> dannies=JsonConvert.DeserializeObject<List<dannie>>(json);
            return dannies ?? new List<dannie>(); ;
        }

        public static void Save2(string dan)
        {
            List<string> allDannie = Read2();
            allDannie.Add(dan);
            string serial = JsonConvert.SerializeObject(allDannie);
            File.WriteAllText("C:\\Users\\Эдуард\\Desktop\\Result2.json", serial);
        }
        public static List<string> Read2()
        {
            string json = File.ReadAllText("C:\\Users\\Эдуард\\Desktop\\Result2.json");
            List<string> dannies = JsonConvert.DeserializeObject<List<string>>(json);
            return dannies ?? new List<string>();
        }

    }
}
