using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that converts a number in the range [0…999] to words, corresponding to the English pronunciation.
namespace Problem_11.Number_as_Words
{
    class NumberAsWords
    {
        static void Main(string[] args)
        {
            string case1, userNumber;
            string[] digits;
            int userInput;
            Console.WriteLine("This is the mother of all programs!");
            Console.Write("Enter a number between 0 and 999: ");
            //This part will validate the user input
            while (!int.TryParse(Console.ReadLine(), out userInput) || (userInput < 0 || userInput > 999))
            {
                Console.Write("Please use numeric values between 0 - 999!: ");
            }
            userNumber = userInput.ToString();
            digits = userNumber.Select(c => c.ToString()).ToArray();
            //This for loop will run thru the array and replace the numbers with theyr corresponding names
            for (int i = 0; i < digits.Length; i++)
            {
                switch (int.Parse(digits[i].ToString()))
                {
                    case 0:
                        digits[i] = "zero";
                        break;
                    case 1:
                        digits[i] = "one";
                        break;
                    case 2:
                        digits[i] = "two";
                        break;
                    case 3:
                        digits[i] = "three";
                        break;
                    case 4:
                        digits[i] = "four";
                        break;
                    case 5:
                        digits[i] = "five";
                        break;
                    case 6:
                        digits[i] = "six";
                        break;
                    case 7:
                        digits[i] = "seven";
                        break;
                    case 8:
                        digits[i] = "eight";
                        break;
                    case 9:
                        digits[i] = "nine";
                        break;
                }
            }
            //This part will determine the case depending on the length of the number
            if (userNumber.ToString().Length == 3)
            {
                case1 = "3";
            }
            else if (userNumber.ToString().Length == 2)
            {
                case1 = "2";
            }
            else
            {
                case1 = "1";
            }
            //This part will crunch the numbers and display the result to the console
            switch (case1)
            {
                case "3":
                    //In this rather scary looking if-else all of the exeptions are dealt with...
                    if (digits[1] == "one" && digits[2] == "zero") //This is for ten
                    {
                        digits[1] = "ten";
                        digits[2] = null;
                    }
                    else if (digits[1] == "one" && digits[2] == "one") //This is for eleven
                    {
                        digits[1] = "eleven";
                        digits[2] = null;
                    }
                    else if (digits[1] == "one" && digits[2] == "two")//This is for twelve
                    {
                        digits[1] = "twelve";
                        digits[2] = null;
                    }
                    else if (digits[1] == "one" && digits[2] == "three")//This is for thirteen
                    {
                        digits[1] = "thirteen";
                        digits[2] = null;
                    }
                    else if (digits[1] == "one" && digits[2] == "five")//This is for fifteen
                    {
                        digits[1] = "fifteen";
                        digits[2] = null;
                    }
                    else if (digits[2] == "zero")//This is in case theres a 0 value at the end of the number
                    {
                        digits[2] = null;
                    }
                    else if (digits[1] == "one")// This is for the teens
                    {
                        digits[1] = digits[2];
                        digits[2] = "teen";
                    }
                    else if (digits[1] == "two")// This is for the twenties
                    {
                        digits[1] = "Twen";
                    }
                    else if (digits[1] == "three") // This is for the thirties
                    {
                        digits[1] = "Thir";
                    }
                    else if (digits[1] == "five") //This is for the fifties
                    {
                        digits[1] = "fif";
                    }
                    if (digits[2] == null) //This is so that the "ty" doesn't get added to the end result (if the middle digit is null) 
                    {
                        Console.WriteLine(digits[0] + " hundred and " + digits[1]);
                        break;
                    }
                    Console.WriteLine(digits[0] + " hundred and " + digits[1] + "ty " + digits[2]);//This is the end result for the 3 digit numbers
                    break;

                case "2":
                    //Don't be afraid of long codes !
                    if (digits[0] == "one" && digits[1] == "zero") //This is for ten
                    {
                        Console.WriteLine("ten");
                        break;
                    }
                    else if (digits[0] == "one" && digits[1] == "one") //This is for eleven
                    {
                        Console.WriteLine("eleven");
                        break;
                    }
                    else if (digits[0] == "one" && digits[1] == "two")//This is for twelve
                    {
                        Console.WriteLine("twelve");
                        break;
                    }
                    else if (digits[0] == "one" && digits[1] == "three")//This is for thirteen
                    {
                        Console.WriteLine("thirteen");
                        break;
                    }
                    else if (digits[0] == "one" && digits[1] == "five")//This is for fifteen
                    {
                        Console.WriteLine("fifteen");
                        break;
                    }
                    else if (digits[1] == "zero")//This is in case theres a 0 value at the end of the number
                    {
                        digits[1] = null;
                    }
                    else if (digits[0] == "one")// This is for the teens
                    {
                        Console.WriteLine(digits[1] + "teen");
                        break;
                    }
                    else if (digits[0] == "two")// This is for the twenties
                    {
                        digits[0] = "Twen";
                    }
                    else if (digits[0] == "three") // This is for the thirties
                    {
                        digits[0] = "Thir";
                    }
                    else if (digits[0] == "five") //This is for the fifties
                    {
                        digits[0] = "fif";
                    }
                    Console.WriteLine(digits[0] + "ty " + digits[1]);//This is the end result for 2 digit printed to the console(unless one of the exeption else-if's has been executed)
                    break;
                case "1":
                    Console.WriteLine(digits[0]);//This is the end result for 1 digit numbers
                    break;
            }
        }
    }
}


