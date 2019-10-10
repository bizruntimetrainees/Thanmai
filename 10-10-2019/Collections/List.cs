using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Concurrent;

namespace Collections
{
    //List class is used to store and fetch elements. It can have duplicate elements.
    class List
    {
        static void Main(string[] args)
        {
            var student_names = new List<string>();

            student_names.Add("Thamai");
            student_names.Add("Jyothirmai");
            student_names.Add("Kiranmai");
            student_names.Add("Chinmai");
            student_names.Remove("Chinmai");



            foreach (var names in student_names)
            {
                Console.WriteLine(names);
                Console.ReadKey();
            }

            var student_names2 = new List<string>()
            {
                "Ramu","Shayam","Vimal","Sonal"

            };

            student_names2.RemoveAt(3);

            foreach (var names2 in student_names2)
            {
                Console.WriteLine(names2);
                Console.ReadKey();
            }




        }
    }
}
