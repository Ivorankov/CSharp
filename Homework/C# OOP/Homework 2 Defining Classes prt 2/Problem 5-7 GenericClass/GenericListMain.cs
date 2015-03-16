
namespace Problem_5_7_GenericClass
{
    using System;
    using System.Collections.Generic;
    class Program
    {
        static void Main(string[] args)
        {
            //Testing the Problem 5 requrements 
            GenericList<int> test = new GenericList<int>();
            test.AddItem(10);
            test.AddItem(11);
            test.AddItem(12);
            test.InsertItem(1, 5);
            Console.WriteLine("Inserting item 5 at index 1...");
            Console.WriteLine(test.ToString());
            test.InsertItem(2, 1);
            Console.WriteLine("Inserting item 1 at index 2...(auto grow kicks in)");
            Console.WriteLine(test.ToString());
            Console.WriteLine("Testing the min value method");
            Console.WriteLine("Min value is: " + test.Min());
            Console.WriteLine("Testing the max value method");
            Console.WriteLine("Max value is: " + test.Max());
            Console.WriteLine("Removing items 5 and 1");
            test.RemoveItem(1);
            test.RemoveItem(2);
            Console.WriteLine(test.ToString());
            Console.WriteLine("Finding elemet in the array...");
            int itemIndex = test.FindItemAtIndex(11);
            Console.WriteLine("Item - " + test.GenericArray[itemIndex] + " Is located at index - " + itemIndex);
            Console.WriteLine("Clearing the array...");
            test.ClearArray();
            Console.WriteLine(test.ToString());
        }
    }
}
