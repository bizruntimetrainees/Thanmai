using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Text_Writer
{
    class TextWriter_example
    {
        static void Main(string[] args)
        {         
           using (TextWriter tw = File.CreateText("D:\\textwriter.txt"))
            {
                tw.WriteLine("This is text writer");
                tw.WriteLine("This is text writer");
                tw.WriteLine("This is text writer");
                tw.WriteLine("This is text writer");



            }

            Console.WriteLine("Data written successfully...");
            Console.ReadKey();
        }
    }
}
