using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Stack_Collec
{
    interface Icars
    {
        void Add();
        void Remove();
        void Retriev();
        void Present();


    }
    class Implements : Icars
    {
        string carname { get; set; }
        public void Add()
        {

            Stack product = new Stack();
            product.Push("BMW");
            product.Push("Ferrari");
            product.Push("Audi");
            product.Push("Benze");


            foreach (string i in product)
            {
                Console.WriteLine(i);
            }

        }

        public void Retriev()
        {
            Stack product = new Stack();
            product.Push("BMW");
            product.Push("Ferrari");
            product.Push("Audi");
            product.Push("Benze");

            Console.WriteLine(product.Peek());

        }

        public void Present()
        {
            Stack product = new Stack();
            product.Push("BMW");
            product.Push("Ferrari");
            product.Push("Audi");
            product.Push("Benze");

            Console.WriteLine(product.Contains("Koenigsegg"));

        }
        public void Remove()
        {
            Stack product = new Stack();
            product.Push("BMW");
            product.Push("Ferrari");
            product.Push("Audi");
            product.Push("Benze");


            while (product.Count > 0)
            {
                Console.WriteLine(product.Pop());
            }
            Console.WriteLine();
            Console.WriteLine(product.Count);

        }


    }
    class Program
    {
        static void Main(string[] args)
        {
            Implements obj = new Implements();
            obj.Add();
            Console.WriteLine();
            obj.Retriev();
            Console.WriteLine();
            obj.Present();
            Console.WriteLine();
            obj.Remove();
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
