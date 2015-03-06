using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_06.Binary_to_hexadecimal
{
    class BinaryToHex
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program converts binary numbers to hex");
            Console.Write("Write some binary number: ");
            string userInput = Console.ReadLine();

            string result = HexToBin(userInput).ToUpper();
            Console.WriteLine("This is your number in hex: " + result);
        }
        static string HexToBin(string hexInput)
        {
            string result = string.Empty;
            hexInput = hexInput.PadLeft(32, '0');
            for (int i = 0; i < hexInput.Length; i += 4)
            {
                switch (hexInput.Substring(i, 4))
                {
                    case "0000":
                        break;
                    case "0001":
                        result += 1;
                        break;
                    case "0010":
                        result += 2;
                        break;
                    case "0011":
                        result += 3;
                        break;
                    case "0100":
                        result += 4;
                        break;
                    case "0101":
                        result += 5;
                        break;
                    case "0110":
                        result += 6;
                        break;
                    case "0111":
                        result += 7;
                        break;
                    case "1000":
                        result += 8;
                        break;
                    case "1001":
                        result += 9;
                        break;
                    case "1010":
                        result += "A";
                        break;
                    case "1011":
                        result += "B";
                        break;
                    case "1100":
                        result += "C";
                        break;
                    case "1101":
                        result += "D";
                        break;
                    case "1110":
                        result += "E";
                        break;
                    case "1111":
                        result += "F";
                        break;
                    default:
                        break;
                }
            }
            return result;
        }

    }
}