using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that generates and prints to the console 10 random values in the range [100, 200]
namespace Problem_02.Random_numbers
{
    
    class RandomGen
    {
        public static Random rndNumber = new Random();
        static void Main(string[] args)
        {
            Console.WriteLine("This is a random program..");
            Console.WriteLine("Heres some random numbers");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(rndNumber.Next(100,200));
            }
        }
    }
}
