using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that finds the maximal sequence of equal elements in an array.
namespace Problem_04.Maximal_sequence
{
    class MaxSequence
    {
        static void Main(string[] args)
        {
            char[] array = new char[] { };//A char array is used because it is not specified what type of elements will be used(numbers,letters,symbols...)
            int count = 0;
            int countDesider = 0;
            int finalCount = 0;
            char maxSequenceChar = 'a';

            Console.WriteLine("This program finds the max sequence of elements");
            Console.WriteLine("Write a text or numbers or whatever you wish(Do not put ',' between each)");
            Console.Write("(Example: 1155533): ");
            string userInput = Console.ReadLine();//Here the user inputs the elements

            array = userInput.ToCharArray();//The user text fills the array

            //This for loop runs for the lenght of the array
            for (int i = 0; i < array.Length-1; i++)
            {
                if (array[i] == array[i + 1])
                {
                    count++;
                    if (countDesider < count)//Initially it will set the value of coutDesider to count, after that countDesider will only increase if count is greater
                    {
                        countDesider = count;
                    }
                    if (count >= countDesider)
                    {
                        maxSequenceChar = array[i];//maxSequenceChar is assigned the value of the current array element
                        finalCount = count;//This is used to determine the ammount of times the for loop below will run.
                    }
                }
                else//When the pair of chars in the array are not equal
                {
                    count = 0;
                }
            }

            //This part prints the result in the console
            Console.WriteLine("The max sequence is: ");
            for (int j = 0; j < finalCount + 1; j++)
            {
                Console.Write("{0}", maxSequenceChar);
                if(j < finalCount)//I desided to put a ',' between all the chars(because thats how its shown in the example)
                {
                    Console.Write(",");
                }
            }
            Console.WriteLine();
        }
    }
}
