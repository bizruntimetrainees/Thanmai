using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    class Dictionary
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dictionary containded key vaues are.....");
            Dictionary<int, string> student_names = new Dictionary<int, string>();
            student_names.Add(1, "Anitha");
            student_names.Add(2, "Bhanukiran");
            student_names.Add(3, "Chandana");
            student_names.Add(4, "Dhanush");
            student_names.Add(5, "Ganesh");
            foreach(KeyValuePair<int,string> s in student_names)
            {
                Console.WriteLine("Key:{0} Value:{1}",s.Key,s.Value);
            }
            Console.WriteLine();

            //  The Count property gets the number of key/ value pairs in a Dictionary. 
            Console.WriteLine("Count:{0}", student_names.Count);

            //Remove property
            Console.WriteLine();
            student_names.Remove(4);
            Console.WriteLine("After removing item...");
            foreach (KeyValuePair<int, string> s in student_names)
            {
                Console.WriteLine("Key:{0} Value:{1}", s.Key, s.Value);
            }

            Console.WriteLine("Count:{0}", student_names.Count);

            //Set the values
            Console.WriteLine("Set the value");

            student_names[9] = "Rani";
            if (!student_names.ContainsKey(2))
            {
              student_names[2] = "Kumar";
            }
            if (!student_names.ContainsValue("Rani"))
            {
                Console.WriteLine("Item found");
            }

            foreach (KeyValuePair<int, string> s in student_names)
            {
                Console.WriteLine("Key:{0} Value:{1}", s.Key, s.Value);
            }

            Console.ReadKey();
             


        }
    }
}
