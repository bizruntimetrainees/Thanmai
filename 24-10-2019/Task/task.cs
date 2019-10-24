using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft;
using Newtonsoft.Json;

namespace Task
{
    class Details
    {
        public string Id { get; set; }
        public string Name { get; set; }

            public void GetDetails()
            {
                Console.Write("Enter Id:");
                Id = Console.ReadLine();

                Console.Write("Enter a name:");
                Name = Console.ReadLine();

            }
             public void printInfo()
              {
                    Console.WriteLine("Record List: ");
                    Console.WriteLine("\tId       : " + Convert.ToInt32(Id));
                    Console.WriteLine("\tName     : " + Convert.ToString(Name));
             }
    }
    class task
    {
       
        static void Main(string[] args)
        {
            int size;
            Console.WriteLine("Enter size:");
            var tempData = Console.ReadLine();
            size = Int32.Parse(tempData);
            Console.WriteLine(size);
           
           
            Details[] d = new Details[size];
           
            for (int i = 0; i < size; i++)
            {
                d[i]= new Details();
            }
         
            for (int i=0;i<size;i++)
            {
              d[i].GetDetails();
              d[i].printInfo();
              Console.WriteLine();
            }

            string output = JsonConvert.SerializeObject(d, Formatting.Indented);
            Console.WriteLine("Serialization Procees start here ..........");
            Console.WriteLine(output);
            Console.WriteLine();      

            var deserializedoutput = JsonConvert.DeserializeObject<Details[]>(output);
            Console.WriteLine("Deserialization Procees start here ..........");
            foreach( var obj in deserializedoutput)
            {
                Console.WriteLine(obj.Name);
                Console.WriteLine(obj.Id);
            } 



            Console.ReadKey();
        }
       
    }
}
