using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Deserilalization
{
    
    class Deserialization_Example
    {
        static void Main(string[] args)
        {
            Studen s = new Studen(1963, "Rakesh");
            FileStream f = new FileStream("D:\\serialization12.txt", FileMode.Create, FileAccess.Write);
            BinaryFormatter bf = new BinaryFormatter();

            bf.Serialize(f, s);
            f.Close();

            FileStream ff = new FileStream("D:\\serialization12.txt", FileMode.Open, FileAccess.Read);
          
            Studen ss = (Studen)bf.Deserialize(ff);
            Console.WriteLine("ID: " + ss.Id);
            Console.WriteLine("Name: " + ss.Name);
            f.Close();
            Console.ReadKey();
        }
    }
}


