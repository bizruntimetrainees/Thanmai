using System;
class MyClient
{
    public static void Main()
    {
        int x = 0;
        int div = 0;
        try
        {
            div = 100 / x;
            Console.WriteLine("This linein not executed");
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Exception occured");
        }
        Console.WriteLine($"Result is {div}");
    }
} 