using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace IEnumarable_Colle
{

    class Example : IEnumerable<string>
    {
        List<string> _elements;

        public Example(string[] array)
        {
            this._elements = new List<string>(array);
        }

        IEnumerator<string> IEnumerable<string>.GetEnumerator()
        {
            Console.WriteLine("HERE");
            return this._elements.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this._elements.GetEnumerator();
        }
    }

    class Program 
    { 
    public static void Main()
        {
        
            Example example = new Example( new string[] { "cat", "dog", "bird" });
           
            foreach (string element in example)
            {
                Console.WriteLine(element);
            }
        }

        Console.ReadLine();
    }



}

