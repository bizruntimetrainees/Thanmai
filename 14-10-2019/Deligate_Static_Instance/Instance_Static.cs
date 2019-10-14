using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deligate_Static_Instance
{
    public delegate void Del(int i, double j);
    public delegate void Del1();
    class Math
    {
        public void MulNum(int p ,double q)
        {
            Console.WriteLine(p * q);
        }

    }

    class Sample
    {
        public void InstanceMethod()
        {
            Console.WriteLine("Instance method invoked");
        }

        public static void StaticMethod()
        {
            Console.WriteLine("Static method invoked");
        }
    }
    class Instance_Static
    {
        static void Main(string[] args)
        {
            Math m = new Math();
            Del d = m.MulNum;
            for(int i= 1;i<=5;i++)
            {
                d(i, 5);
            }
           
            Console.WriteLine(d);
            Console.WriteLine();

            Sample s = new Sample();
            Del1 d2 = new Del1(s.InstanceMethod);
            d2();
            Console.WriteLine();


            Del1 d1 = new Del1(Sample.StaticMethod);
            d1();

            Console.ReadKey();



        }
    }
}
