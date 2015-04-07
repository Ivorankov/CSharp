namespace Problem_05._64_Bit_array
{
    using System;
    class Program
    {

        public static void Main()
        {
            var longNum = new BitArray64();
            longNum[20] = 1;
            longNum[4] = 1;
            longNum[31] = 1;
            longNum[55] = 1;
            Console.WriteLine(longNum);
        }
    }
}