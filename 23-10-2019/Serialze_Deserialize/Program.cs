using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft;
using Newtonsoft.Json;

namespace Newtonsoft_JSON.NET
{
    class Product
    {
        public string Name { get; set; }
        public DateTime ExpiryDate { get; set; }
        public double Price { get; set; }
        public String[] Sizes{ get; set; }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Product productobj = new Product();

            productobj.Name = "Apple";
            productobj.ExpiryDate = new DateTime(2008, 12, 28);
            productobj.Price = 3.99;
            productobj.Sizes = new string[] { "Small", "Medium", "Large" };

            string output = JsonConvert.SerializeObject(productobj, Formatting.Indented);

            Console.WriteLine("Serialization Procees start here ..........");
            Console.WriteLine(output);
            //Console.ReadKey();
            Console.WriteLine(); 

            Product deserializedProduct = JsonConvert.DeserializeObject<Product>(output);
            Console.WriteLine("Deserialization Procees start here ..........");
            Console.WriteLine(deserializedProduct.Name);
            Console.WriteLine(deserializedProduct.ExpiryDate);
            Console.WriteLine(deserializedProduct.Price);
            Console.WriteLine(JsonConvert.SerializeObject(deserializedProduct.Sizes));
        
            Console.WriteLine();


            //JSON TO FILE
            JSON_to_file.GetDetails();

            Console.ReadKey();

        



        }
    }
}
