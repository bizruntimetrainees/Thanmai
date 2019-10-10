using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sortedset
{
    class Sorted
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

            Console.WriteLine("The elements in the numafter sorting");
            SortedSet<int> num= new SortedSet<int>();

            num.Add(10);
            num.Add(30);
            num.Add(50);
            num.Add(40);
            num.Add(20);

            foreach (int i in num)

            {

                Console.WriteLine(i);

            }

            //count the number of element in the days and num
            Console.WriteLine("The number of element in the days are:" + days.Count());
            Console.WriteLine("The number of element in the num are:" + num.Count());

            //The maximum value in the days and num
            Console.WriteLine("The maximum element in SortedSet is:" + days.Max());
            Console.WriteLine("The maximum element in SortedSet1 is:" + num.Max());

            //The minimum value in the days and num
            Console.WriteLine("The maximum element in SortedSet is:" + days.Min());
            Console.WriteLine("The maximum element in SortedSet1 is:" + num.Min());

            //apply contain method
            Console.WriteLine("The element Monday contain in the SortedSet : " + days.Contains("Monday"));
            Console.WriteLine("The element Saturday contain in the SortedSet : " +days.Contains("Saturday"));
            Console.WriteLine("The element December contain in the SortedSet : " + days.Contains("Decemberrr"));
            Console.WriteLine("The element 12 contain in the SortedSet : " + num.Contains(12));
            Console.WriteLine("The element 20 contain in the SortedSet : " + num.Contains(20));

            //Clear methd
            days.Clear();
            num.Clear();
            Console.WriteLine("The number of element after apply the clear method in the days is:" + days.Count());
            Console.WriteLine("The number of element after apply the clear method in the num is:" + num.Count());
            Console.ReadKey();

        }
    }


    }
