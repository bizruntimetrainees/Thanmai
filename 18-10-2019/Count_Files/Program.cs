using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Count_Files
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] filePaths = Directory.GetFiles(@"D:\Textfiles");
            for (int i = 0; i < filePaths.Length; ++i)
            {
                string path = filePaths[i];
                Console.WriteLine(System.IO.Path.GetFileName(path));
            }

      

           foreach (string file in Directory.GetFiles(@"D:\Textfiles"))
            {
                Console.WriteLine(file);
            }
            
            Console.ReadKey();
        }
    }
}
