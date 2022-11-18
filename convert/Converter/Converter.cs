using Newtonsoft.Json;
using System.Xml.Serialization;

namespace Converter
{
	public class Clas
	{
        public Clas()
        {}
		public Clas(string length, string width, string height)
		{
			this.length = length;
			this.width = width;
			this.height = height;
		}
		public string length;
		public string width;
		public string height;
	}

	class Converter
	{
		public Converter()
		{
			
		}
		public void Print()
		{
			string format = "txt";
			Console.WriteLine("Введите путь файлa");
			string Path = Console.ReadLine();
			Console.Clear();
			Console.WriteLine("F5 - сохранение файла | Esc - выйти");

			if (Path.Contains(".json"))
			{
				DeserializeJson(Path);
				format = "json";
			}
			else if (Path.Contains(".txt"))
            {
				DeserializeTxt(Path);
				format = "txt";
			}
			else if (Path.Contains(".xml"))
			{
				DeserializeXml(Path);
				format = "xml";
			}
			ConsoleKeyInfo key = Console.ReadKey();
			switch (key.Key)
			{
				case ConsoleKey.F5:
					Serialize(Path, format);
					break;
				case ConsoleKey.Escape:
					Environment.Exit(0);
					break;
			}
		}
		private void Serialize(string Path, string format)
		{
			List<Clas> New = new List<Clas>();
			string text = File.ReadAllText(Path);
			string[] lines = File.ReadAllLines(Path);
			int line = 0;
			if (format == "json")
			{
                New = JsonConvert.DeserializeObject<List<Clas>>(text);
			}
			else if (format == "txt")
			{
				for (int i = 0; i < lines.Length / 3; i++)
				{
					string length = File.ReadLines(Path).Skip(0 + line).First();
					string width = File.ReadLines(Path).Skip(1 + line).First();
					string height = File.ReadLines(Path).Skip(2 + line).First();
                    Clas new1 = new Clas(length, width, height);
                    New.Add(new1);
					line += 3;
				}
			}
			else if (format == "xml")
            {
				XmlSerializer xml = new XmlSerializer(typeof(List<Clas>));
				using (FileStream fs = new FileStream(Path, FileMode.Open))
				{
                    New = (List<Clas>)xml.Deserialize(fs);
				}
			}
            
			Console.Clear();
			Console.WriteLine("Введите путь для сохранения файла");
			string path_to = Console.ReadLine();
			if (path_to.Contains(".json"))
			{
				string json = JsonConvert.SerializeObject(New);
				File.WriteAllText(path_to, json);
			}
			else if (path_to.Contains(".xml"))
			{
				XmlSerializer xml = new XmlSerializer(typeof(List<Clas>));
				using (FileStream fs = new FileStream(path_to, FileMode.OpenOrCreate))
				{
					xml.Serialize(fs, New);
				}
			}
			else if (path_to.Contains(".txt"))
			{
				foreach (Clas nn in New)
                {
					File.AppendAllText(path_to, nn.length + "\n");
					File.AppendAllText(path_to, nn.height + "\n");
					File.AppendAllText(path_to, nn.width + "\n");
                }
			}
		}
		static void DeserializeJson(string Path)
        {
			string text = File.ReadAllText(Path);
			List<Clas> New = new List<Clas>();	
			List<Clas> conv = JsonConvert.DeserializeObject<List<Clas>>(text);
			foreach (Clas i in conv)
            {
				Console.WriteLine(i.length);
                Console.WriteLine(i.width);
				Console.WriteLine(i.height);
                New.Add(i);
			}
            
        }
		static void DeserializeTxt(string Path)
        {
			string text = File.ReadAllText(Path);
			Console.WriteLine(text);
        }
		static void DeserializeXml(string Path)
        {
			List<Clas> i;
			List<Clas> New = new List<Clas>();
			XmlSerializer xml = new XmlSerializer(typeof(List<Clas>));
            using (FileStream fs = new FileStream(Path, FileMode.Open))
            {
                i = (List<Clas>)xml.Deserialize(fs);
            }
			foreach (var n in i)
            {
				Console.WriteLine(n.length);
				Console.WriteLine(n.width);
				Console.WriteLine(n.height);
                New.Add(n);
			}
        }
	}
}
