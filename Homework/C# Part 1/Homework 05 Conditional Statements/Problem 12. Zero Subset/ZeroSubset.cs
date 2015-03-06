using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//We are given 5 integer numbers. Write a program that finds all subsets of these numbers whose sum is 0.
//Assume that repeating the same subset several times is not a problem.
namespace Problem_12.Zero_Subset
{
    class ZeroSubset
    {
        static void Main(string[] args)
        {

            int i, check,count;
            bool test1;
            int userInput1, userInput2, userInput3, userInput4, userInput5;
            Console.WriteLine("This program finds all subsets of a given set of numbers(5 numbers)");
            Console.WriteLine("Please enter the 5 numbers (press enter after each one): ");

            //This will validate the user input
            while (!int.TryParse(Console.ReadLine(), out userInput1)
                || !int.TryParse(Console.ReadLine(), out userInput2)
                || !int.TryParse(Console.ReadLine(), out userInput3)
                || !int.TryParse(Console.ReadLine(), out userInput4)
                || !int.TryParse(Console.ReadLine(), out userInput5))
            {
                Console.WriteLine("Please use numeric values and make sure you press Enter after each number :");
            }
            int[] numbers = new int[5]{userInput1,userInput2,userInput3,userInput4,userInput5};
            test1 = numbers[3] + numbers[4] == 0;
            count = 0;

            Console.Clear();
            Console.WriteLine("Your numbers:{0} {1} {2} {3} {4}", userInput1, userInput2, userInput3, userInput4, userInput5);
            //This will check the obvious
            if (numbers[0] + numbers[1] + numbers[2] + numbers[3] + numbers[4] == 0)
            {
                Console.WriteLine("{0} and {1} and {2} and {3} and {4}", numbers[0], numbers[1], numbers[2], numbers[3], numbers[4]);
                count++;
            }

            //These for loops will loop thru the array that was created by the user input
            //This part checks 2 numbers at a time
            for (i = 1; i < numbers.Length; i++)
            {
                check = numbers[0] + numbers[i];
                if (check == 0)
                {
                    Console.WriteLine("{0} and {1}", numbers[0], numbers[i]);
                    count++;
                }
            }
            for (i = 2; i < numbers.Length; i++)
            {
                check = numbers[1] + numbers[i];
                if (check == 0)
                {
                    Console.WriteLine("{0} and {1}", numbers[1], numbers[i]);
                    count++;
                }
            }
            for (i = 3; i < numbers.Length; i++)
            {
                check = numbers[2] + numbers[i];
                if (check == 0)
                {
                    Console.WriteLine("{0} and {1}", numbers[2], numbers[i]);
                    count++;
                }
            }
            if (test1)//Theres is only one check for [3] and [4] so there is no point of making a for loop 
            {
                Console.WriteLine("{0} and {1}", numbers[3], numbers[4]);
                count++;
            }

            //This part will check 3 numbers at a time
            for (i = 2; i < numbers.Length; i++)
            {
                check = numbers[0] + numbers[1] + numbers[i];
                if (check == 0)
                {
                    Console.WriteLine("{0} and {1} and {2}", numbers[0], numbers[1], numbers[i]);
                    count++;
                }
            }
            for (i = 3; i < numbers.Length; i++)
            {
                check = numbers[1] + numbers[2] + numbers[i];
                if (check == 0)
                {
                    Console.WriteLine("{0} and {1} and {2}", numbers[1], numbers[2], numbers[i]);
                    count++;
                }
            }
            for (i = 4; i < numbers.Length; i++)
            {
                check = numbers[1] + numbers[3] + numbers[i];
                if (check == 0)
                {
                    Console.WriteLine("{0} and {1} and {2}", numbers[1], numbers[3], numbers[i]);
                    count++;
                }
            }
            for (i = 2; i < numbers.Length - 1; i++)
            {
                check = numbers[4] + numbers[0] + numbers[i];
                if (check == 0)
                {
                    Console.WriteLine("{0} and {1} and {2}", numbers[4], numbers[0], numbers[i]);
                    count++;
                }
            }

            //This part will check 4 numbers at a time
            for (i = 3; i < numbers.Length; i++)
            {
                check = numbers[0] + numbers[1] + numbers[2] + numbers[i];
                if (check == 0)
                {
                    Console.WriteLine("{0} and {1} and {2} and {3}", numbers[0], numbers[1], numbers[2], numbers[i]);
                    count++;
                }
            }
            for (i = 0; i < numbers.Length; i = i + 4)
            {
                check = numbers[1] + numbers[2] + numbers[3] + numbers[i];
                if (check == 0)
                {
                    Console.WriteLine("{0} and {1} and {2} and {3}", numbers[1], numbers[2], numbers[3], numbers[i]);
                    count++;
                }
            }
            for (i = 1; i < numbers.Length - 1; i = i + 2)
            {
                check = numbers[4] + numbers[0] + numbers[2] + numbers[i];
                if (check == 0)
                {
                    Console.WriteLine("{0} and {1} and {2} and {3}", numbers[4], numbers[0], numbers[2], numbers[i]);
                    count++;
                }
            }
            if (count == 0) //This handles the case where no subsets are found
            {
                Console.WriteLine("No subsets for you!");
            }
            else
            {
                Console.WriteLine("There are a total of " + count + " subsets in that set of numbers");//This just adds a little touch in the end :)
            }
        }
    }
}
