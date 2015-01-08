using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Create a console application that calculates and prints the square root of the number 12345.(and add a little twist here and there :P)
namespace SquareRoot
{
    class sqrtRoot
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Would you like to know what the sqrtroot of 12345 is?");
            Console.WriteLine("Yes/No");
            string Answer=Console.ReadLine();
            Answer = Answer.ToLower();
            if (Answer == "yes")
            {
                Console.WriteLine("It's  "+Math.Sqrt(12345));
            }
            else if (Answer == "no")
            {
                Console.WriteLine("Ok....Here's the sqrt of 54321  " + Math.Sqrt(54321));
                Console.WriteLine("HA !!! :D");
            }
            else
            {
                Console.WriteLine("You failed to provide the correct answer");
                Console.WriteLine("This program will selfdestruct in 5 seconds!!!");
            }
        }
    }
}
