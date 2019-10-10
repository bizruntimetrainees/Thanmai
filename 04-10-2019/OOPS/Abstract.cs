using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{
    abstract class Demo
    {
        public int Int1 { get; set; }
        public void Method1()
        {
            Console.WriteLine("Demo Method1");
        }

        public abstract int Int2 
        {
            get;
            set;
        }
        public abstract void Method2();  

    }

    class Drived : Demo
    {
        public int Val;
        public override int Int2
        {
            get
            {
                return Val;
            }
            set
            {
                Val = value;
            }
        }

        public override void Method2()
        {
            Console.WriteLine("Drived Method2");
        }
    }
    class AbstarctResult    {
        static void Main()
        {

            Drived Dr = new Drived();
            Dr.Int1 = 10;
            Dr.Int2 = 20;
            Dr.Method1();
            Dr.Method2();
            Console.ReadLine();
        }

    }
}
