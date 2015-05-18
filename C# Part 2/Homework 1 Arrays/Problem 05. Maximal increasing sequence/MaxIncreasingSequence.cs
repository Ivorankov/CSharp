using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that finds the maximal increasing sequence in an array.
namespace Problem_05.Maximal_increasing_sequence
{
    class MaxIncreasingSequence
    {
        static void Main(string[] args)
        {
            char[] array = new char[] { };//Again I use a char array, meaning it will work for numbers or letters(1,2,3/a,b,c)
            int count = 0;
            int countDesider = 0;
            int lastIndex = 0;
            char[] resultArray = new char[0];
            List<char> bufferList = new List<char>();

            Console.WriteLine("This program finds the max increasing sequence in an array");

            //This part takes the input from the user and fills the char array
            Console.WriteLine("Enter numbers or letters(Do not put ',' between each one");
            Console.Write("Example (11234558 or abcdyze): ");
            string userInput = Console.ReadLine();
            array = userInput.ToCharArray();

            //This for loop will run for the ammount of chars in the array -1(if its not -1 the index[i+1] will go outside of the boundries of the array
            for (int i = 0; i < array.Length-1; i++)
            {
                if (array[i + 1] - array[i] == 1)//When the char codes of the chars are subtracted and the result is 1.. (b-a = 1)(2-1 = 1)  
                {
                    count++;
                    bufferList.Add(array[i]);//Thoes chars go in this buffer list
                    if (countDesider < count)//The point of this is if there are more then one sequence it will determine the greater one(12350123 - 0123 is greater...)
                    {
                        resultArray = new char[bufferList.Count];//Who sayd arrays aren't resizable :D
                        countDesider = count;
                        bufferList.CopyTo(resultArray);//Here the contents of the buffer are copyed to a simple char array (resultArray)
                        lastIndex = i + 1;//This gets the index of the array[i+1](The way the buffer list is filled the last char from the sequence doesn't go in it
                    }

                }
                else
                {
                    bufferList.Clear();//After the contents of the buffer are copyed to the resultArray, they get cleared(deleted), leaving the buffer empty
                    count = 0;         //The idea is if another sequence is encountered it starts filling the list again
                }
            }

            //This part will print the result in the console
            for (int n = 0; n < resultArray.Length; n++)
            {
                Console.Write("{0}", resultArray[n]);
                if (n < resultArray.Length)
                {
                    Console.Write(",");
                }
            }
            Console.Write("{0}", array[lastIndex]);//This adds the missing last char to the final result 
            Console.WriteLine();
        }
    }
}
