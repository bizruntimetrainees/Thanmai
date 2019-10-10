using System;
class MyClient
{
    public static void Main()
    {
        try
        {
            throw new DivideByZeroException("Invalid Division");
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Exception");
        }
        Console.WriteLine("LAST STATEMENT");
    }  
}