using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Declare two string variables and assign them with the following value: The "use" of quotations causes difficulties.
//Do the above in two different ways - with and without using quoted strings.
//Print the variables to ensure that their value was correctly defined.

namespace Problem_7.Quotes_in_Strings
{
    class Quotes
    {
        static void Main(string[] args)
        {
            string noQuotes = "The use of quotations causes difficulties.";
            string Quotes = @"The ""use"" of quotations causes difficulties";

            Console.WriteLine(noQuotes);
            Console.WriteLine(Quotes);
        }
    }
}
