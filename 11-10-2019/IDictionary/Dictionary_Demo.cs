using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Idictionary
{
    interface IValue
    {
        void Render();
    }

    class Content : IValue
    {
        public void Render()
        {
            Console.WriteLine("Render content");
        }
    }

    class Image : IValue
    {
        public void Render()
        {
            Console.WriteLine("Render image");
        }
    }

    class Dictionary_Demo
    {
        static void Main()
        {
            var dictionary = new Dictionary<string, IValue>();
            dictionary.Add("cat", new Image());
            dictionary.Add("dog", new Image());
            dictionary.Add("home", new Content());

            // Look up interface objects and call implementations.
            IValue value;
            if (dictionary.TryGetValue("cat", out value))
            {
                value.Render(); 
            }
            if (dictionary.TryGetValue("home", out value))
            {
                value.Render(); 
            }
            Console.ReadKey();
        }
    }

}
