using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<string> names = new LinkedList<string>();
            names.AddLast("Varamahalakshmi");
            names.AddLast("Tripura");
            names.AddLast("Sundari");
            names.AddLast("Devi");
            names.AddFirst("Sri");  

            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine();
            Console.WriteLine("After the node insertion in middle");

            LinkedListNode<String> n = names.Find("Varamahalakshmi");
            names.AddBefore(n, "Sidda");
            names.AddAfter(n, "Bala");

            foreach (string name in names)
            {
                Console.WriteLine(name);
            } 
            Console.ReadKey();
        }
    }
}
