using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assembly1_DLL_
{
    public class A
    {
        private int x = 5;
        public void Foo()
        { 
            Console.WriteLine(x);
        }
        protected static void Goo()
        {
        }
        protected internal class NestedType
        { 
        }
    }
    internal class B
    {
        private void Hoo()
        {
            A a1 = new A(); 
            Console.WriteLine(a1.x); 
            A.NestedType n; 
            A.Goo(); 
        }
    }

}
