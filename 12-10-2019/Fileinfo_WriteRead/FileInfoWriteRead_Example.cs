using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Fileinfo_WriteRead
{
    class FileInfoWriteRead_Example
    {
        static void Main(string[] args)
        {
            //Write data into a file
            try 
            { 
            string loc = "D:\\fileinfo_create.txt";
            FileInfo file = new FileInfo(loc);
            StreamWriter sw = file.CreateText();
            sw.WriteLine("This text is written to the file by using StreamWriter class.");
            sw.Close();
            }
            catch(IOException e)  
            {  
                Console.WriteLine("Something went wrong: "+e);  
            }

            //Readin file
            string loc1 = "D:\\fileinfo_create.txt";

            FileInfo file1 = new FileInfo(loc1);

            StreamReader sr = file1.OpenText();
            string data = "";

            while ((data = sr.ReadLine()) != null)
            {
                Console.WriteLine(data);
            }
            //create a file
           string loc2 = "D:\\fileinfo_delete.txt";
            FileInfo file3 = new FileInfo(loc2);
            file3.Create(); 

            //Deleting a file
            string loc4 = "D:\\fileinfo_delete.txt";
            FileInfo file4 = new FileInfo(loc4);
            file4.Delete();


            Console.ReadKey();

        }
    }
}
