using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling_Asynch
{
    class Test_Exception
    {
        public Task Show()
        {
            return Task.Run(() =>
            {
                try
                {
                    Task.Delay(2000);
                    throw new Exception("Exception is Occured");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    return null;
                }
            });
        }
        public async void Result()
        {
            try
            {
                await Show();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
    class Async_Exception
    {
        static void Main(string[] args)
        {
            Test_Exception t = new Test_Exception();
            t.Result();
            Console.ReadLine();
        }
    }
}
