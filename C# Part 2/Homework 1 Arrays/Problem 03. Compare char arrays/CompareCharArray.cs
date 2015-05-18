using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that compares two char arrays lexicographically (letter by letter).
namespace Problem_03.Compare_char_arrays
{
    class CompareCharArray
    {
        static void Main(string[] args)
        {

            Console.WriteLine("This program compares two char arrays");

            char[] charArray1 = new char[]{ };
            char[] charArray2 = new char[]{ };
            int lenght = 0;

            //This part will fill the arrays with chars
            Console.WriteLine("Fill the first array with chars(Just write some text in a single line)");
            string userText = Console.ReadLine();
            charArray1 = userText.ToCharArray();
   
            Console.WriteLine("Fill the second array with chars(Just write some text in a single line)");
            userText = Console.ReadLine();
            charArray2 = userText.ToCharArray();
            Console.Clear();

            //This if will check if both chars have equal lenght
            if (charArray1.Length != charArray2.Length)
            {
                if (charArray1.Length > charArray2.Length)
                {
                    Console.WriteLine("The length of the first array is greater then the second one");
                }
                else
                {
                    Console.WriteLine("The length of the second array is greater then the first one");
                }
                Console.WriteLine("No worries, I shall compare them somehow... \n");
                lenght = Math.Min(charArray1.Length, charArray2.Length);//Because we dont want the user to start all over again we get the lesser lenght an compare both arrays to that lenght
            }
            else
            {
                lenght = charArray1.Length;//If both arrays have equal lenght
            }

            //This part will compare the two arrays 
            for (int i = 0; i < lenght; i++)
            {
                string charIndex1 = "Array1[" + i + "]";
                string charIndex2 = "Array2[" + i + "]";
                if (charArray1[i] == charArray2[i])
                {
                    Console.WriteLine("{0} '{1}' is equal to {2} '{3}'",charIndex1, charArray1[i], charIndex2, charArray2[i]);
                }
                else
                {
                    Console.WriteLine("{0} '{1}' is not equal to {2} '{3}'", charIndex1, charArray1[i], charIndex2, charArray2[i]);
                }
            }
        }
    }
}
