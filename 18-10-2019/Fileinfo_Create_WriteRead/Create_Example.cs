using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace FileInfo_Create
{
    class Create_Example
    {
        static void Main(string[] args)
        {
            try
            {
                string loc = "D:\\fileinfo_create.txt";
                FileInfo file = new FileInfo(loc);
                file.Create();
                Console.WriteLine("File is created Successfuly");
            }catch (IOException e)
            {
                Console.WriteLine("Something went wrong: " + e);
            }


            Console.ReadKey();
        }
    }
}
