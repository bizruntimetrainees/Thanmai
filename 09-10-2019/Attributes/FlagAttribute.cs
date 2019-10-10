using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlagAttribute
{
    //The FlagsAttribute specifies that an enumeration can be used as a set of flags.
    //This is most commonly used with bitwise operators
    enum Colours
    {
        Red = 1,
        Blue = 2,
        Pink = 4,
        Green = 8
    }
    [Flags]
    enum ColoursFlags
    {
        Red = 1,
        Blue = 2,
        Pink = 4,
        Green = 8
    }
    class FlagAttribute
    {
        static void Main(string[] args)
        {
            Console.WriteLine((Colours.Red | Colours.Blue).ToString());
            Console.WriteLine((ColoursFlags.Red | ColoursFlags.Blue).ToString());
            Console.ReadKey();
        }
    }
}
