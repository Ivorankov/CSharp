using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a method that reverses the digits of given decimal number.
namespace Problem_07.Reverse_number
{
    class ReverseNumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program reverses numbers");

            //This part takes the user input
            Console.Write("Write a number you wish to reverse: ");
            decimal userNumber = decimal.Parse(Console.ReadLine());

            //This part calls the method and prints the result in the console
            decimal result = Reverse(userNumber);
            Console.WriteLine("Your number in reverse is: " + result);
        }
        static decimal Reverse(decimal x)
        {
            string reversedString = String.Empty;
            decimal reversedNumber = 0;
            char[] array = x.ToString().ToCharArray();//Puts the input number in a char array
            Array.Reverse(array);//An it reverses it
            for (int i = 0; i < array.Length; i++)
            {
                reversedString += array[i];//A temp string is used to put the reversed digirs together
            }
            reversedNumber = decimal.Parse(reversedString);
            return reversedNumber;
        }
    }
}
