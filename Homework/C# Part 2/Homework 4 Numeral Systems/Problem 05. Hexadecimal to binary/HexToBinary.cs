using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_05.Hexadecimal_to_binary
{
    class HexToBinary
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program converts hex numbers to binary");
            Console.Write("Write some hex number: ");
            string userInput = Console.ReadLine();

            string result = HexToBin(userInput);
            Console.WriteLine("This is your number in binary: " + result);
        }
        static string HexToBin(string hexInput)
        {
            string result = string.Empty;

            for (int i = 0; i < hexInput.Length; i++)
            {
                switch (hexInput[i])
                {
                    case '0':
                        result += "0000";
                        break;
                    case '1':
                        result += "0001";
                        break;
                    case '2':
                        result += "0010";
                        break;
                    case '3':
                        result += "0011";
                        break;
                    case '4':
                        result += "0100";
                        break;
                    case '5':
                        result += "0101";
                        break;
                    case '6':
                        result += "0110";
                        break;
                    case '7':
                        result += "0111";
                        break;
                    case '8':
                        result += "1000";
                        break;
                    case '9':
                        result += "1001";
                        break;
                    case 'A':
                        result += "1010";
                        break;
                    case 'B':
                        result += "1011";
                        break;
                    case 'C':
                        result += "1100";
                        break;
                    case 'D':
                        result += "1101";
                        break;
                    case 'E':
                        result += "1110";
                        break;
                    case 'F':
                        result += "1111";
                        break;
                }
            }
            return result;
        }

    }
}

