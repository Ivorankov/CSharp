using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_04.Hexadecimal_to_decimal
{
    class HexToDecimal
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program finds the decimal value of a hex number");

            Console.Write("Please enter a number in hex: ");
            string userHex = Console.ReadLine().ToUpper();

            long result = HexToDec(userHex);
            Console.WriteLine("Your number in decimal is: " + result); 

        }
        static long HexToDec(string userHex)
        {
            string[] hexArray = userHex.Select(c => c.ToString()).ToArray();//This puts the user's hex into an array
            //This for & switch case will replace all the letters with theyr corresponding number
            for (int i = 0; i < hexArray.Length; i++)
            {
                switch (hexArray[i])
                {
                    case "A":
                        hexArray[i] = "10";
                        break;
                    case "B":
                        hexArray[i] = "11";
                        break;
                    case "C":
                        hexArray[i] = "12";
                        break;
                    case "D":
                        hexArray[i] = "13";
                        break;
                    case "E":
                        hexArray[i] = "14";
                        break;
                    case "F":
                        hexArray[i] = "15";
                        break;
                }
            }
            long decResult = 0;
            long result2 = 0;
            long result1,y;
            int index = 0;
            //This for loop will run for all the elemets in the array
            for (int x = hexArray.Length - 1; x >= 0; x--)
            {
                y = Convert.ToInt64(Math.Pow(16, x));//This is 16^n
                result1 = long.Parse(hexArray[index]) * y;//This multiplys the number in the given array index[n] with 16^n
                result2 = result2 + result1;//And this just sums all the numbers
                index++;//This increases every time the for loop...ehm loops...and it sets the next array index
            }
            decResult = result2;
            return decResult;
        }
    }
}

