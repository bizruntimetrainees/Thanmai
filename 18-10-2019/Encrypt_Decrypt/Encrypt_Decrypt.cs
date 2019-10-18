using System;
using System.IO;
using System.Security.AccessControl;

namespace FileSystemExample
{
    class FileExample
    {
        public  void AddEncryption(string FileName)
        {
            FileInfo fInfo = new FileInfo(FileName);
            if (!fInfo.Exists)
            {
                StreamWriter sw = File.CreateText(FileName);
             
                sw.WriteLine("this file is encrypted");
                sw.Close();
            }

            fInfo.Encrypt();
        }

       public  void AddDecrypt(string FileName)
        {
            FileInfo fInfo = new FileInfo(FileName);
            if (!fInfo.Exists)
            {
                fInfo.Create();
            }
            fInfo.Decrypt();

        } 
    }
    class Encrypt_Decrypt_example
    {
        public static void Main()
        {
            string FileName = @"D:\MyEncryptfile.txt";

            FileExample f = new FileExample();
            Console.WriteLine("Encrypt " + FileName);
            f.AddEncryption(FileName);

            Console.WriteLine("Decrypt " + FileName);
                f.AddDecrypt(FileName);
            Console.WriteLine("Done"); 


        }
    }
}
