using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Directory_Info
{
    class DirectoryInfo_Example
    {
        static void Main(string[] args)
        {
            // Provide directory name with complete location.  
            DirectoryInfo directory = new DirectoryInfo(@"E:\Example");
            try
            {
                // Check, directory exist or not.  
                if (directory.Exists)
                {
                    Console.WriteLine("Directory already exist.");
                    return;
                }
                // Creating a new directory.  
                directory.Create();
                Console.WriteLine("The directory is created successfully.");
            }
            catch (Exception e)
            {
                Console.WriteLine("Directory not created: {0}", e.ToString());
            }

            DirectoryInfo directory1= new DirectoryInfo(@"E:\Example");

            directory1.Delete();
            Console.WriteLine("The directory is deleted successfully.");
        }
    }
    }

