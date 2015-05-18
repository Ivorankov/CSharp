using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Classical play cards use the following signs to designate the card face: 
//`2, 3, 4, 5, 6, 7, 8, 9, 10, J, Q, K and A. Write a program that enters a string and prints “yes” if it is a valid card sign or “no” otherwise.
namespace Problem_03.Check_for_a_Play_Card
{
    class CheckACard
    {
        static void Main(string[] args)
        {
            string input;

            Console.WriteLine("Check a card, your goto place for card checking!");
            Console.Write("Please enter a card you wish to check: ");
            input = Console.ReadLine().ToUpper();  //This will take the user input, I use ToUpper because you dont know if the user will use caps or not.

            switch (input)
            {
                case "2":
                    Console.WriteLine("Yes");
                    break;
                case "3":
                    Console.WriteLine("Yes");
                    break;
                case "4":
                    Console.WriteLine("Yes");
                    break;
                case "5":
                    Console.WriteLine("Yes");
                    break;
                case "6":
                    Console.WriteLine("Yes");
                    break;
                case "7":
                    Console.WriteLine("Yes");
                    break;
                case "8":
                    Console.WriteLine("Yes");
                    break;
                case "9":
                    Console.WriteLine("Yes");
                    break;
                case "10":
                    Console.WriteLine("Yes");
                    break;
                case "J":
                    Console.WriteLine("Yes");
                    break;
                case "Q":
                    Console.WriteLine("Yes");
                    break;
                case "K":
                    Console.WriteLine("Yes");
                    break;
                case "A":
                    Console.WriteLine("Yes");
                    break;
                default:
                    Console.WriteLine("No");
                    break;
            }
        }
    }
}
