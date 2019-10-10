using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{
    class Location
    {
        string name;
        public string Name
        {
            get
            {
                return name;
            }
        }

        public Location(string name)
        {
            this.name = name;
        }

        public void Display()
        {
            Console.WriteLine(Name);
        }

    }

    class URL:Location
    {
      public URL(string name):base(name)
        {

        }

        public void Navigate()
        {
            Console.WriteLine("Navigate to:" + Name);
        }
    }

    class Locationfile:Location
    {
        public Locationfile(string name) : base(name)
        {

        }

        public void Execute()
        {
            Console.WriteLine("Execute to:" + Name);
        }

    }



    class Result
    {
        public static void Main()
        {

             void show(Location loc)
            {
                Console.Write("Location is:");
                loc.Display();
            }

            URL u = new URL("Thanmai");
            Locationfile l = new Locationfile("THE NAME IS:");
            show(u);
            show(l);

        }

    }

}

