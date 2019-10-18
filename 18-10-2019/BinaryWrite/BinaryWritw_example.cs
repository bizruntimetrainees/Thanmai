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
            static string filename = "D:\\binaryreadwrite.bin";
            public static void writebinary()
            {

                using (BinaryWriter bw = new BinaryWriter(File.Open(filename, FileMode.Create)))
                {
                    bw.Write(2.5);
                    bw.Write("Hello C#");
                    bw.Write(true);

                  

                    Console.WriteLine("Equals():"+bw.Equals(bw)); 
                    Console.WriteLine("GetHashCode():"+bw.GetHashCode());

                    Console.WriteLine( "GetType():"+bw.GetType());

                    // Sets the position within the current stream.
                    Console.WriteLine("SEEK():"+ bw.Seek(0, SeekOrigin.Begin));
                    Console.WriteLine("SEEK():"+bw.Seek(16, SeekOrigin.Current));
                    Console.WriteLine("SEEK():"+bw.Seek(48, SeekOrigin.End));

                    Console.WriteLine("ToString():"+bw.ToString());

                    bw.Dispose();

                  //bw.Flush();

                    bw.Close(); 


            }

        }
           public static void readbinary()
            {

                using (BinaryReader br = new BinaryReader(File.Open(filename, FileMode.Open)))
                {
                    Console.WriteLine("Double value:" + br.ReadDouble());
                    Console.WriteLine("String value:" + br.ReadString());
                    Console.WriteLine("Boolean value:" + br.ReadBoolean());
                    br.Dispose();
                    Console.WriteLine("Equals:" + br.Equals(br));
                    Console.WriteLine("GetHashCode:" + br.GetHashCode());
                    Console.WriteLine("GetTyp:" + br.GetType());
                    Console.WriteLine("String value:" + br.PeekChar());
                    Console.WriteLine("Boolean value:" + br.Read()); 
                    Console.WriteLine("Double value:" + br.ReadByte());
                    Console.WriteLine("Boolean value:" + br.ReadChar());
                    Console.WriteLine("ToString:" + br.ToString());
                  
                    br.Close();     

            }
            } 
        class BinaryWritw_example
        {
            static void Main(string[] args)
            {
                BinarReaderEx.writebinary();
                Console.WriteLine();

                Console.WriteLine("Data is Reading:");
                BinarReaderEx.readbinary();
                Console.WriteLine("Data read successfully:");
                Console.ReadKey();

            }
        }
    }
    }

