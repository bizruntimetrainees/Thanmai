using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    class Stack
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Stack elements are...");
            Stack<int> s = new Stack<int>();

            s.Push(90);
            s.Push(70);
            s.Push(50);
            s.Push(30);
            s.Push(10);
            s.Push(25);

            foreach(int i in s)
            {
                Console.WriteLine(i);
            }
            

            Console.WriteLine("Peek element is:" + s.Peek());
            Console.WriteLine("Pop element is:" + s.Pop());
            Console.WriteLine("Now Peek element is:" + s.Peek());
            Console.WriteLine();


            Console.WriteLine("Stack elements are...");
            s.Push(98);
            s.Push(17);

            foreach (int i in s)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("Peek element is:" + s.Peek());
            Console.WriteLine("Pop element is:" + s.Pop());
            Console.WriteLine("Now Peek element is:" + s.Peek());


            Console.ReadKey();
        }
    }
}
