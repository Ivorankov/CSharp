using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Declare a character variable and assign it with the symbol that has Unicode code 42 (decimal) using the \u00XX syntax, and then print it.
namespace Problem_4.Unicode_Character
{
    class Unicode
    {
        static void Main(string[] args)
        {
            string Uni = "\u002A";

            Console.WriteLine(Uni);
        }
    }
}
