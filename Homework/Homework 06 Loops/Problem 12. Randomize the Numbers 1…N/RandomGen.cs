using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that enters in integer n and prints the numbers 1, 2, …, n in random order.
namespace Problem_12.Randomize_the_Numbers_1_N
{
    class RandomGen
    {
        static void Main(string[] args)
        {
            int n, userMin, userMax, i;
            Random random = new Random();
            Console.WriteLine("This program is random");

            //This part validates the user input
            Console.Write("Set the max number value: ");
            while (!int.TryParse(Console.ReadLine(), out userMax) || userMax <= 1)
            {
                Console.Write("Please use numeric values!(the Max cannot be lower or equal then 1): ");
            }

            Console.WriteLine();
            Console.WriteLine("Here's some random numbers!");
            //This for loop will run the random gen for as many times as it takes for 1 to reach the user selected number
            for (i = 0; i < userMax; i++)
            {
                Console.Write("{0,-5}",random.Next(1, userMax + 1));
            }
            Console.WriteLine("WOW, Now thats random! :D");
        }
    }
}
