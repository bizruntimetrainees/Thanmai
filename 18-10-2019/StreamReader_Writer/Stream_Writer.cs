using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace FileStreamWriter
{
    class Stream_Writer
    {
        static void Main(string[] args)
        {
            FileStream f = new FileStream("D:\\output.txt", FileMode.Create);
            StreamWriter s = new StreamWriter(f);
            StreamWriter s1 = new StreamWriter(f);

            s.WriteLine("This file is created using streamwrite");

            s.Close();
            f.Close();
            Console.WriteLine("File created successfully in your Requireds Location ...");
            Console.ReadKey();


        }
    }
}
