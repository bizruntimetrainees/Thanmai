using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Elements in the Queue are");

            Queue<string> names = new Queue<string>();
            names.Enqueue("Sam");
            names.Enqueue("Ruth");
            names.Enqueue("Prabu");
            names.Enqueue("Nayak");
            names.Enqueue("Vikram");

            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine("Peek element: " + names.Peek());
            Console.WriteLine("Dequeue: " + names.Dequeue());
            Console.WriteLine("After Dequeue, Peek element: " + names.Peek());
            Console.WriteLine();


            Console.WriteLine("Elements in the Queue are");
            names.Enqueue("Mahendar");
            names.Enqueue("Varma");

            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine("Peek element: " + names.Peek());
            Console.WriteLine("Dequeue: " + names.Dequeue());
            Console.WriteLine("After Dequeue, Peek element: " + names.Peek());

            Console.ReadKey();
        }
    }

}
