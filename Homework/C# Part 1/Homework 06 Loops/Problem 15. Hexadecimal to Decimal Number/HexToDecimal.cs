using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Using loops write a program that converts a hexadecimal integer number to its decimal form.
//The input is entered as string. The output should be a variable of type long.
//Do not use the built-in .NET functionality.
namespace Problem_15.Hexadecimal_to_Decimal_Number
{
    class HexToDecimal
    {
        static void Main(string[] args)
        {
            string userHex;
            int i,x,z;
            long decResult, y,result1,result2;
            string[] hexArray = new string[]{ };
            Console.WriteLine("This program finds the decimal value of a hex number");

            Console.Write("Please enter a number in hex: ");
            userHex = Console.ReadLine();

            hexArray = userHex.Select(c => c.ToString()).ToArray();//This puts the user's hex into an array
            //This for & switch case will replace all the letters with theyr corresponding number
            for (i = 0; i < hexArray.Length; i++)
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
            decResult = 0;
            z = 16;
            i = 0;
            result2 = 0;
            //This for loop will run for all the elemets in the array
            for (x = hexArray.Length-1; x >= 0; x--)
            {
                    y = Convert.ToInt64(Math.Pow(z, x));//This is 16^n
                    result1 = long.Parse(hexArray[i]) * y;//This multiplys the number in the given array index[n] with 16^n
                    result2 = result2 + result1;//And this just sums all the numbers
                    i++;//This increases every time the for loop...ehm loops...and it sets the next array index
            }
            decResult = result2;
            Console.WriteLine("Your number in decimal is = " + decResult);
        }
    }
}
