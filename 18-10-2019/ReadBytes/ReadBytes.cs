using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileStreamRead
{
    class ReadBytes
    {
        static void Main(string[] args)
        {
            FileStream f2 = new FileStream("D:\\data.txt", FileMode.OpenOrCreate);

            int j = 0;
            while ((j = f2.ReadByte()) != -1)
            {
                Console.Write((char)j);
            }
            f2.Close();
            Console.ReadKey();
        }
    }
}
