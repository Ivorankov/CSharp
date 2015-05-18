using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_03.Decimal_to_hexadecimal
{
    class DecimalToHex
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program finds the hex value of a decimal number");
            Console.Write("Write some number: ");
            long userInput = long.Parse(Console.ReadLine());
            string result = string.Empty;

            result = DecToHex(userInput);
            Console.WriteLine("Your number in hex is: " + result);

        }
        static string DecToHex(long decimalInput)
        {
            string[] hexArray = new string[9];
            long result1, result2, y;
            int i = 0;
            result2 = decimalInput;
            for (int x = 8; x >= 0; x = x - 1)
            {

                y = Convert.ToInt64(Math.Pow(16, x));
                if (decimalInput > y)//Once 16^n becomes less then the user input number 
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
            string hexResult = string.Join("", hexArray);//This puts the contents of the array in a string
            return hexResult;
        }
    }
}
