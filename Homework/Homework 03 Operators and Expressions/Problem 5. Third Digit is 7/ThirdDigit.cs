using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write an expression that checks for given integer if its third digit from right-to-left is 7.
class ThirdDigit
{
    static void Main(string[] args)
    {
        int n;
        Console.WriteLine("Right lets get started, get it ? :D ");
        Console.Write("Enter a number: ");
        n = Convert.ToInt32(Console.ReadLine());

        if ((n = n / 100) % 10 == 7) 
        {
            Console.WriteLine("Yes bravo! You chose 7 as the 3-rd last digit and now im telling you its 7...");
        }
        else 
        {
            Console.WriteLine("Nope its not 7");
        }
     }
}


