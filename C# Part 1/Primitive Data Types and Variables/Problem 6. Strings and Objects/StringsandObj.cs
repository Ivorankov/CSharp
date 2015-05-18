using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Declare two string variables and assign them with Hello and World.
// Declare an object variable and assign it with the concatenation of the first two variables (mind adding an interval between).
//Declare a third string variable and initialize it with the value of the object variable (you should perform type casting).

namespace Problem_6.Strings_and_Objects
{
    class StringsandObj
    {
        static void Main(string[] args)
        {
            string H = "Hello";
            string W = "World";
            object HW =(H+" "+W);
            string HopeThisWorks = Convert.ToString(HW);

            Console.WriteLine(HopeThisWorks);
        }
    }
}
