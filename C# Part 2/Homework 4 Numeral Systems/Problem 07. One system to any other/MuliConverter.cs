using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_07.One_system_to_any_other
{
    class MuliConverter
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program converts numeral systems");

            Console.Write("Write a number: ");
            string userNumber = (Console.ReadLine()).ToUpper();
            Console.Write("Enter numberal system to convert From: ");
            int baseFrom = int.Parse(Console.ReadLine());
            Console.Write("Enter numberal system to convert To: ");
            int baseTo= int.Parse(Console.ReadLine());

            Console.Write("Your number in " + baseTo + " system is: ");
            DecimalToBase(BaseToDecimal(userNumber, baseFrom), baseTo);
            
        }


            static int BaseToDecimal(string input, int baseFrom)
            {
                int decResult = 0;
                for (int i = 0; i < input.Length; i++)
                {
                    if (input[i] > '9')
                    {
                        decResult += (input[i] - 55) * (int)Math.Pow(baseFrom, (input.Length - 1 - i));
                    }
                    else
                    {
                        decResult += (input[i] - 48) * (int)Math.Pow(baseFrom, (input.Length - 1 - i));
                    }
                }
                return decResult;
            }
            static void DecimalToBase(int input, int baseTo)
            {
                List<int> result = new List<int>();
                if (baseTo > 10)//If there will be hex letters or not 
                {
                    while (input > 0)
                    {
                        result.Add(input % baseTo);
                        input = input / baseTo;
                    }
                    result.Reverse();//Because theyget filled from the last to the first
                    foreach (var item in result)//For the hex letters
                    {
                        switch (item)
                        {
                            case 10:
                                Console.Write('A');
                                break;
                            case 11:
                                Console.Write('B');
                                break;
                            case 12:
                                Console.Write('C');
                                break;
                            case 13:
                                Console.Write('D');
                                break;
                            case 14:
                                Console.Write('E');
                                break;
                            case 15:
                                Console.Write('F');
                                break;
                            default:
                                Console.Write(item);
                                break;
                        }
                    }
                    Console.WriteLine();
                }
                else
                {
                    while (input > 0)
                    {
                        result.Add(input % baseTo);
                        input = input / baseTo;
                    }
                    result.Reverse();
                    foreach (var item in result)
                    {
                        Console.Write(item);
                    }
                    Console.WriteLine();
                }
            }
        }
    }
