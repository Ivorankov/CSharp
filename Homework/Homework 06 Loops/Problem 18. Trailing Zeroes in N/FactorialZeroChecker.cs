using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

//Write a program that calculates with how many zeroes the factorial of a given number n has at its end.
//Your program should work well for very big numbers, e.g. n=100000.
namespace Problem_18.Trailing_Zeroes_in_N
{
    class FactorialZeroChecker
    {
        static void Main(string[] args)
        {
            BigInteger factorial;
            int i, userNumber, count;

            Console.WriteLine("This program will count the 0's in the end of a factorialed? number");
            Console.WriteLine("It works with huge numbers tho the large numbers take a while to calculate(MAX 240000)...");//The max is set because there is no point of going higher
                                                                                                                           //+ at that number it takes a min or 2 to count all the 0's...
            //This part will validate the user input
            Console.Write("Enter the number you wish to see the factorial of the...wait, WHAT?: ");
            while (!int.TryParse(Console.ReadLine(), out userNumber) || userNumber>240000)
            {
                Console.WriteLine("Please use numeric values!(MAX 240K!): ");
            }
            Console.WriteLine();
            factorial = 1;
            count = 0;

            //This for loop creates the factorial of the number
            for (i = 1; i <= userNumber; i++)
            {
                factorial = factorial * i;
            }
            if (userNumber >= 50000)//This is just a little msg for the user
            {
                Console.WriteLine("Halfish way there , DONT GIVE UP!");
            }
            if (userNumber > 20000)//This is needed because of the "tuning" of the factorial number below(it will crash the program if its smaller)
            {
                string myStr = Convert.ToString(factorial);//I convert the Bigint into a string
                string SubString = myStr.Substring(myStr.Length - 60000);//And here i get only the last 60k digits , meaning it will count the 0's allllotttt faster... 
                BigInteger shortFactorial = BigInteger.Parse(SubString);//And here the new number is parsed back to BigInt

                //This while loop runs for the ammount of times as there are 0's and yes it takes ages if the user enters 100000 and higher...
                while (shortFactorial % 10 == 0)//Because we cut a ton of digits off the number this while will work for factorial numbers no greater then about 240000
                {                               //if the "trail of zeros" is greater then 60k well then it will get stuck in the while loop forever... 
                    shortFactorial = shortFactorial / 10;
                    count++;
                }
            }
            else//In here go the smaller numbers as they contain alot less digits its fast to count the 0's 
            {
                while (factorial % 10 == 0)
                {
                    factorial = factorial / 10;
                    count++;
                }
            }
            if (count > 15000)//This is again just a little added msg for the user
            {
                Console.WriteLine("Apparently there are " + count + " zeros." + " Your electric bill is now + 10 lv :P");
            }
            else
            {
                Console.WriteLine("Apparently there are " + count + " zeros");
            }
        }
    }
}
