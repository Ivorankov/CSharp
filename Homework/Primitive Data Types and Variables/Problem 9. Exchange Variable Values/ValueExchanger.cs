using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Declare two integer variables a and b and assign them with 5 and 10 and after that exchange their values by using some programming logic.
//Print the variable values before and after the exchange.
namespace Problem_9.Exchange_Variable_Values
{
    class ValueExchanger
    {
        static void Main(string[] args)
        {
            sbyte a, b, n;
            a = 5;
            b = 10;
            Console.WriteLine("The two numbers are:");
            Console.WriteLine("a = 5  and b=10");
            Console.WriteLine("Do the switch?");
            Console.WriteLine("Yes/No");
            string User = Console.ReadLine();
            User = User.ToLower();

            if (User == "yes")
            {
                n = a;
                a = b;
                b = n;
                Console.WriteLine("a="+ a + " b=" + b);
            }
            else if (User=="no")
            {
                Console.WriteLine("Ok the values remain unchanged");
                Console.WriteLine("a=" + a + " b=" + b);
            }
        }
    }
}
