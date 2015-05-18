using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//You are given n integers (given in a single line, separated by a space).
//Write a program that checks whether the product of the odd elements is equal to the product of the even elements.
//Elements are counted from 1 to n, so the first element is odd, the second is even, etc.
namespace Problem_10.Odd_and_Even_Product
{
    class OddAndEven
    {
        static void Main(string[] args)
        {
            string[] userInput;
            char[] ui;
            int odd, even;
            Console.WriteLine("This program compares the product of odd and even elements");
            Console.Write("Please enter the numbers you want (in a single line separated by a space): ");

            userInput = Console.ReadLine().Split();//This array gets filled by the user
            even = 1;
            odd = 1;

            Console.WriteLine();
            for (int i = 1; i < userInput.Length; i = i + 2)//This runs for the even possitions in the array
            {
                even = even * int.Parse(userInput[i]);//This multiplys all the even numbers
            }
            for (int i = 0; i < userInput.Length; i = i + 2)//This runs for the odd possitions in the array
            {
                odd = odd * int.Parse(userInput[i]);//This multiplys all the odd numbers
            }

            //This does a simple check and prints the results to the console
            if (odd == even)
            {
                Console.WriteLine("Yes the product of the even and odd elemets is equal");
                Console.WriteLine("The product of the odd is: " + odd);
                Console.WriteLine("The product of the even is: " + even);
            }
            else
            {
                Console.WriteLine("Nope they aren't");
                Console.WriteLine("The product of the odd is: " + odd);
                Console.WriteLine("The product of the even is: " + even);
            }
        }
    }
}
