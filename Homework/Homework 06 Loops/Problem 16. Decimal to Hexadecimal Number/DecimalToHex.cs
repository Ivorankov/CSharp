using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Using loops write a program that converts an integer number to its hexadecimal representation.
//The input is entered as long. The output should be a variable of type string.
//Do not use the built-in .NET functionality.
namespace Problem_16.Decimal_to_Hexadecimal_Number
{
    class DecimalToHex
    {
        static void Main(string[] args)
        {
            long userInput, y, result1, result2;
            string hex, hexResult;
            int x, z, i;
            string[] hexArray = new string[9];
            Console.WriteLine("This program finds the hex value of a decimal number");

            //This part will validate the user input
            Console.Write("Please enter some number: ");
            while (!long.TryParse(Console.ReadLine(), out userInput))
            {
                Console.Write("Please use numeric values!: ");
            }

            z = 16;
            result2 = userInput;
            i = 0;
            hex = string.Empty;
            //This for loop will run 9 times (for 16^8 till 16^0)
            for (x = 8; x >= 0; x = x - 1)
            {
                y = Convert.ToInt64(Math.Pow(z, x));
                if (userInput > y)//Once 16^n becomes less then the user input number 
                {
                    //Initially result2 = userinput as set on line 29, after that it takes new value each time the for loop runs
                    result1 = result2 / y;
                    result2 = result2 - (result1 * y);
                    hexArray[i] = Convert.ToString(result1);//This puts all the numbers in a string array
                    i++;
                }
            }
            //This loop & switch case run thru the array and switch the values 10-15 with theyr corresponding letter
            for (i = 0; i < 9; i++)
            {
                switch (hexArray[i])
                {
                    case "10":
                        hexArray[i] = "A";
                        break;
                    case "11":
                        hexArray[i] = "B";
                        break;
                    case "12":
                        hexArray[i] = "C";
                        break;
                    case "13":
                        hexArray[i] = "D";
                        break;
                    case "14":
                        hexArray[i] = "E";
                        break;
                    case "15":
                        hexArray[i] = "F";
                        break;
                }
            }
            hexResult = string.Join("", hexArray);//This puts the contents of the array in a string
            Console.WriteLine("Your number in hex format is = " + hexResult);
        }
    }
}
