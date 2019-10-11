using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arraylist
{
    class Person
    {
        public string Name { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            List<Person> List = new List<Person>()
            {
            new Person{Name="Amulya"},
            new Person{Name="Aanandh"},
            new Person{Name="Akhila"},
            new Person{Name="Avinash"},
            };
            List.Add(p);
            List.RemoveAt(1);
          

            foreach (Person O in List)
            {
                Console.WriteLine(O.Name);
            }

            Console.ReadLine();
        }
    }
}
