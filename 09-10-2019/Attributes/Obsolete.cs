using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obsolete
{
    //The ObsoleteAttribute marks the code elements that are obsolete i.e. not in use anymore.
    //Calling these obsolete code elements results in a compiler error
    class Obsolete
    {
        [Obsolete("method1 is obsolete", true)]
        static void method1()
        {
            Console.WriteLine("This is method1");
        }

        static void method2()
        {
            Console.WriteLine("This is method2");
        }
        static void Main(string[] args)
        {
            method1(); 
            method2();
        }
    }
}
