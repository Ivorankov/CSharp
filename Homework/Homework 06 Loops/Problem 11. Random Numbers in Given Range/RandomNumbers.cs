using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that enters 3 integers n, min and max (min != max) and prints n random numbers in the range [min...max].
namespace Problem_11.Random_Numbers_in_Given_Range
{
    class RandomNumbers
    {
        static void Main(string[] args)
        {
            int n, userMin, userMax, i;
            Random random = new Random();
            Console.WriteLine("This program is random");

            //This part validates the user input
            Console.Write("Choose the amount of numbers: ");
            while (!int.TryParse(Console.ReadLine(), out n) || n < 1)
            {
                Console.Write("Please use numeric values greater then 0!: ");
            }
            Console.Write("Set the min number value: ");
            while (!int.TryParse(Console.ReadLine(), out userMin))
            {
                Console.Write("Please use numeric values!: ");
            }
            Console.Write("Set the max number value: ");
            while (!int.TryParse(Console.ReadLine(), out userMax) || userMax < userMin)
            {
                Console.Write("Please use numeric values!(the Max cannot be lower then the Min value): ");
            }

            Console.WriteLine();
            Console.WriteLine("Here's some random numbers!");
            //This for loop will run the random gen for as many times as the user has chosen
            for (i = 0; i < n; i++)
            {
                Console.Write("{0,-5}",random.Next(userMin, userMax + 1));
            }
            Console.WriteLine("WOW, Now thats random! :D");
        }
    }
}
