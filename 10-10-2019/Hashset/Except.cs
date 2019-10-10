using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hashset_Except
{
    class Except
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

            names1.ExceptWith(names);
            Console.WriteLine("Non common names are...");

            foreach (var name in names1)
            {
                Console.WriteLine(name);
            }
            Console.ReadKey();
        }
    }
}
