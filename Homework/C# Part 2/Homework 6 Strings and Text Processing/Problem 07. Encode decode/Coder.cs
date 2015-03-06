using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that encodes and decodes a string using given encryption key (cipher).
//The key consists of a sequence of characters.
//The encoding/decoding is done by performing XOR (exclusive or) operation over the first letter of the string 
//with the first of the key, the second – with the second, etc. When the last key character is reached, the next is the first.
namespace Problem_07.Encode_decode
{
    class Coder
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program is better then the Enigma machine!");
            Console.Write("Write the encription key: ");
            string encription = Console.ReadLine();
            Console.Write("Write your message: ");
            string message = Console.ReadLine();

            string encripted = Encription(message, encription);
            Console.WriteLine("After encription: " + encripted);
            string decripted = Decription(encripted, encription);
            Console.WriteLine("Decription test: " + decripted);

        }
        static string Encription(string message, string encrKey)
        {
            string encriptedResult = string.Empty;
            int index = 0;
            for (int i = 0; i < message.Length; i++)
            {
                encriptedResult += (char)(message[i] ^ encrKey[index]);
                index++;
                if (index > encrKey.Length - 1)
                {
                    index = 0;
                }
            }
            return encriptedResult.ToString();
        }
        static string Decription(string message, string encrKey)
        {
            string encriptedResult = string.Empty;
            int index = 0;
            for (int i = 0; i < message.Length; i++)
            {
                encriptedResult += (char)(message[i] ^ encrKey[index]);
                index++;
                if (index > encrKey.Length - 1)
                {
                    index = 0;
                }
            }
            return encriptedResult.ToString();
        }
    }
}
