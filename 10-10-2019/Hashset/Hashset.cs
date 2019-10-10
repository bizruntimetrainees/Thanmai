using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Concurrent;


namespace Hashset
{
    //Duplicates are not allowed
    class Hashset
    {
        static void Main(string[] args)
        {
            HashSet<string> student_names = new HashSet<string>();
            student_names.Add("Thamai");
            student_names.Add("Jyothirmai");
            student_names.Add("Kiranmai");
            student_names.Add("Chinmai");
            student_names.Add("Jyothirmai");//It is duplicates it wont display
            student_names.Add("Chinna");

            Console.WriteLine("Inserted Elements are..");

            foreach (string names in student_names)
            {
                Console.WriteLine(names);
            }

            Console.ReadKey();

            HashSet<string> names1 = new HashSet<string>
            {
                "Thamai",
                "Jyothirmai",
                "Kiranmai",
                "Rajeev",
                "Akash",
                "Amit",
                "Deepak",
                "Mohit"
            };

            //Union will combined both elements
            student_names.UnionWith(names1);
            Console.WriteLine("Union method starts here....");
            foreach (string names in student_names)
            {
                Console.WriteLine(names);
            }
            Console.ReadKey();


        }
    }
}