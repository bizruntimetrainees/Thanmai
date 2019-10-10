using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{
    class @sealed
    {
        public static void Main()
        {}
             class X
        {
            protected virtual void F()
            {
                Console.WriteLine("X.F");

            }
            protected virtual void F2()
            {
                Console.WriteLine("X.F2");
            }
        }

        class Y : X
        {
            sealed protected override void F()
            {
                Console.WriteLine("Y.F");
            }
            protected override void F2()
            {
                Console.WriteLine("X.F3");
            }
        }

        class Z : Y
        {
            protected override void F()
            {
                Console.WriteLine("C.F");
            }
            protected override void F2()
            {
                Console.WriteLine("Z.F2");
            }
        }

    }
       
    }

 }

         
