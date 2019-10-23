using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft;
using Newtonsoft.Json;
using System.IO;


namespace Newtonsoft_JSON.NET
{
    class JSON_to_file
    {
        public string moviename { get; set; }
        public int year{ get; set; }

        public static void GetDetails()
        {
            JSON_to_file js = new JSON_to_file();
            js.moviename = "NEW YORK";
            js.year = 1998;

            string op = JsonConvert.SerializeObject(js, Formatting.Indented);
            Console.WriteLine("serialization Procees of another class start here ..........");
            File.WriteAllText(@"D:\Newtonsoft JSON.NET\text.json", op);

            using (StreamWriter file = File.CreateText(@"D:\Newtonsoft JSON.NET\text.json"))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(file, op);
            }



            JSON_to_file js1 = JsonConvert.DeserializeObject<JSON_to_file>(File.ReadAllText(@"D:\Newtonsoft JSON.NET\text.json"));

            Console.WriteLine("Deserialization Procees of another class start here ..........");

            using (StreamReader file = File.OpenText(@"D:\Newtonsoft JSON.NET\text.json"))
            {
                JsonSerializer serializer = new JsonSerializer();

                JSON_to_file js2 = (JSON_to_file)serializer.Deserialize(file, typeof(JSON_to_file));
            }
        }


    }
}
