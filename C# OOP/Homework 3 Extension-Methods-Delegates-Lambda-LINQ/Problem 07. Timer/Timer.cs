//Using delegates write a class Timer that can execute certain method at each t seconds.
namespace Problem_07.Timer
{
    using System;
    using System.Threading;

    public delegate void ImADeligate(int timer);
    class Timer
    {
        static void TestMethod(int timer)
        {
                Thread.Sleep(timer);
                Console.WriteLine("OMG IT WORKED IT WORKEDDDD");
        }
        
        static void Main()
        {
            ImADeligate test = new ImADeligate(TestMethod);
            test(2000);
        }
    }
}
