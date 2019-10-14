using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anonymous_method
{
    public delegate void Del(int n);
    class Anonymous_Test
    {

        static void Main(string[] args)
        {
            int i = 10;
            Del d = delegate (int val)
                     {
                         val = val + i;
                         Console.WriteLine("Inside the anonymous methos the value is {0}", val);
                     };
            d(100);
            Console.ReadKey();
        }
    
    }
}
