using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileStreamReader
{
    class Stream_Reader
    {
        static void Main(string[] args)
        {
            FileStream f = new FileStream("D:\\output.txt", FileMode.OpenOrCreate);
            StreamReader s = new StreamReader(f);

           string line = "";
            while ((line = s.ReadLine()) != null)
            {
                Console.WriteLine(line);
            }
            s.Close();
            f.Close();
            Console.ReadKey();
        }
        }
    }

