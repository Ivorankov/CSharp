using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that applies bonus score to given score in the range [1…9] by the following rules:
//If the score is between 1 and 3, the program multiplies it by 10.
//If the score is between 4 and 6, the program multiplies it by 100.
//If the score is between 7 and 9, the program multiplies it by 1000.
//If the score is 0 or more than 9, the program prints “invalid score”.

namespace Problem_02.Bonus_Score
{
    class BonusScore
    {
        static void Main(string[] args)
        {
            int score;

            Console.WriteLine("This program will give score points !");
            Console.Write("Choose score (from 1 to 9): ");
            //This part will validate the user input
            while (!int.TryParse(Console.ReadLine(), out score) || (score > 9 || score < 1))   
            {
                Console.WriteLine("Please use numeric values between 1 and 9!");
                Console.Write("Choose score (from 1 to 9): ");
            }
            //This part will check the input value and work the math and WriteLine magic
            if (score == 1 || score <= 3)  
            {
                score = score * 10;
                Console.WriteLine("The score is: " + score);
            }
            else if (score == 4 || score <= 6)
            {
                score = score * 100;
                Console.WriteLine("The score is: " + score);
            }
            else 
            {
                score = score * 1000;
                Console.WriteLine("The score is: " + score);
            }
        }
    }
}
