using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Asynchronous
{
    class Test
    {
        private static Task<Int32> Method2()
        {
            return Task.Run(() =>
            {
                Thread.Sleep(5000);
                return 1;
            }
            );
        }
        public async static Task Method1()
        {
            var _returnValue = await Method2();
            Console.WriteLine(Environment.NewLine + " Call to Asynchronous process completed with value" + _returnValue);
        }
    }
    class asyn_awit
    {
        
        static void Main(string[] args)
        {

            Console.WriteLine("starting th asynchronous process" + Environment.NewLine);
           Test.Method1();
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("This is  synchronous process completed with value" + i);
            }
            Console.ReadLine();
        }
    }
}
