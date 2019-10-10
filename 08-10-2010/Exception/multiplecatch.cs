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
            Console.WriteLine("Not executed line");
        }
        catch (DivideByZeroException de)
        {
            Console.WriteLine("DivideByZeroException");
        }
        catch (Exception)
        {
            Console.WriteLine("Exception");
        }
        finally
        {
            Console.WriteLine("Finally Block");
        }
        Console.WriteLine($"Result is {div}");
    }
}