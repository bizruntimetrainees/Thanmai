using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hashset_Intersect
{
    class Intersect
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inserted  names are...");

            HashSet<string> names = new HashSet<string> {
                "Rajeev",
                "Akash",
                "Amit"
            };
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine("Newly inserted names are...");

            HashSet<string> names1 = new HashSet<string> {
                "Rajeev",
                "Akash",
                "Amit",
                "Deepak",
                "Mohit"
            };
            foreach (var name in names1)
            {
                Console.WriteLine(name);
            }

            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
            names.IntersectWith(names1);
            Console.WriteLine("The common names are...");
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
            Console.ReadKey();


        }
    }
}
