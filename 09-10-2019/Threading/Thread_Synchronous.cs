using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Threading_Synchronous
{
    class Thread_Synchronous
    {
        static  void Work1()
        {
            for(int i=1;i<=5;i++)
            {
                Console.WriteLine("Work-1 is running" + i.ToString());
            }
        }

        static void Work2()
        {
            for (int i=6;i<=10;i++)
            {
                Console.WriteLine("Work-2 is running" + i.ToString());
            }
        }
        static void Main(string[] args)
        {
            Work1();
            Work2();
            Console.ReadKey();
        }
    }
}
