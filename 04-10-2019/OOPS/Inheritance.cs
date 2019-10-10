using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Inheritance
    {
        public string name;

        public string Name
        {
            get
            {
                return name;
            }
        }
        public Inheritance(string name)
        {
            this.name = name;
        }

        public void Display()
        {
            Console.WriteLine(Name);
        }
    }

    class Child:Inheritance
    {
        public void Navigate()
        {
           
        Console.WriteLine("Navigating to " + Name);
        }

        public Child(string name) : base(name)
        {
        }
    }

    class Test
     {
         public static void Main()
         {
             Child u = new Child("Thanmai");
             u.Display();
             u.Navigate();
         } 


     
}

