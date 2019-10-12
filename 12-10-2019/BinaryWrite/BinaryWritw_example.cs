using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BinaryWrite_Read
{
    //used to write binary information into stream. 

        class BinarReaderEx
        {
            static string filename = "D:\\binaryreadwrite.txt";
            public static void writebinary()
            {

                using (BinaryWriter bw = new BinaryWriter(File.Open(filename, FileMode.Create)))
                {
                    bw.Write(2.5);
                    bw.Write("Hello C#");
                    bw.Write(true);
                }

            }
            public static void readbinary()
            {

                using (BinaryReader br = new BinaryReader(File.Open(filename, FileMode.Open)))
                {
                    Console.WriteLine("Double value:" + br.ReadDouble());
                    Console.WriteLine("String value:" + br.ReadString());
                    Console.WriteLine("Boolean value:" + br.ReadBoolean());


                }
            }
        class BinaryWritw_example
        {
            static void Main(string[] args)
            {
                BinarReaderEx.writebinary();
                BinarReaderEx.readbinary();
                Console.ReadKey();
                Console.WriteLine("Data read successfully:");

            }
        }
    }
    }

