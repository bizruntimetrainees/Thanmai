using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorted_Remove
{
    class Remove
    {
        static void Main(string[] args)
        {

            SortedSet<string> days = new SortedSet<string>();

            days.Add("Sunady");
            days.Add("Monday");
            days.Add("Tuesday");
            days.Add("Wednesday");
            days.Add("Thusday");
            days.Add("Friday");
            days.Add("Saturday");

            Console.WriteLine("The elements in the days after sorting:");
            foreach (string str in days)

            {

                Console.WriteLine(str);

            }

            Console.WriteLine("The elements in the num after sorting");
            SortedSet<int> num = new SortedSet<int>();

            num.Add(10);
            num.Add(30);
            num.Add(50);
            num.Add(40);
            num.Add(20);

            foreach (int i in num)

            {

                Console.WriteLine(i);

            }

            // remove the elements from string type sortedset

            days.Remove("Monday");
            days.Remove("Tuesday");
            days.Remove("Sunday");

            Console.WriteLine();

            Console.WriteLine("After removal of the elements from the days is as:");

            Console.WriteLine();

            foreach (string s in days)

            {
                Console.WriteLine(s);

            }

            //remove the elements from integer type sortedset

            num.Remove(10);
            num.Remove(20);
            num.Remove(40);

            Console.WriteLine();

            Console.WriteLine("After removal of the elements from the num is as:");

            Console.WriteLine();

            foreach (int s in num)

            {

                Console.WriteLine(s);

            }

            days.RemoveWhere(Element => Element.StartsWith("T"));
            Console.WriteLine();

            Console.WriteLine("After removal of the elements from the dayss is as:");

            Console.WriteLine();

            foreach (string s in days)

            {

                Console.WriteLine(s);

            }
            Console.ReadKey();
        }
    }
}
