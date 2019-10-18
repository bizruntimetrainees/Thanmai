using System;
using System.IO;

class Test
{

    public static void Main()
    {
        string sourceFile = @"D:\Thanmai.txt";
        string destinationFile = @"D:\ThanmaiCopied.txt";
        try
        {
            File.Copy(sourceFile, destinationFile, true);
        }
        catch (IOException iox)
        {
            Console.WriteLine(iox.Message);
        }

        string sourceFile2 = @"D:\data.txt";
        string destinationFile2= @"D:\dataCopied.txt";
        try
        {
            File.Copy(sourceFile2, destinationFile2, true);
        }
        catch (IOException iox)
        {
            Console.WriteLine(iox.Message);
        }
        Console.ReadKey();
    }
}