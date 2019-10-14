using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multicast_Delegate
{
    public delegate void Del(string s);

    class Test
    {
         public static void Hello(string s)
         {
            Console.WriteLine("Hello{0}" +"    ",s);
         }
        public static void Welcome(string s)
        {
            Console.WriteLine("Welcome TO{0}" + "  ", s);
        }


        public static void Bye(string s)
        {
            Console.WriteLine("Bye{0}"+"    ", s);
        }

    }
    class Multicast
    {
        static void Main(string[] args)
        {
            Del d1 = new Del(Test.Hello);
            d1("Thanmai");
            Console.WriteLine();


            Del d2 = new Del(Test.Welcome);
            d2("BIZRUNTIME");
            Console.WriteLine();


            Del d3 = new Del(Test.Bye);
            d3("Thanmai");
            Console.WriteLine();


            Del d4 = d1 + d2 + d3;
            d4("Teena");
            Console.WriteLine();

            Del d5 = d1 + d2 - d3;
            d5("Teena");
            Console.WriteLine();



            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
