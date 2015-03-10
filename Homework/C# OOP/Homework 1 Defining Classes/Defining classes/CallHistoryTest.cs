using System;
using System.Collections.Generic;


class CallHistoryTest
{
    private GSM test = new GSM("Juke","MobilTek");//Problem 12

    public void AddCalls()
    {
            Call calls = new Call("087007", 123, DateTime.Now, DateTime.Now);
            test.AddRemoveCall(calls, true);
            calls = new Call("+359 89 5111 445", 59, DateTime.Now, DateTime.Now.AddHours(1));//Wow them future people are calling
            test.AddRemoveCall(calls, true);
            calls = new Call("0200154565", 240, DateTime.Now.AddDays(1), DateTime.Now.AddHours(5));
            test.AddRemoveCall(calls, true);
    }
    public void DisplayInfo()
    {
        var displayCalls = test.CallHistory;
        foreach (var calls in displayCalls)
        {
            Console.WriteLine("Number: " + calls.PhoneNumber);
            Console.WriteLine("Call Duration: " + calls.CallDuration + " ,s");
            Console.WriteLine("Date of call: " + calls.Date.Date.ToString("dd.MM.yy"));
            Console.WriteLine("Time of call: " + calls.Time.TimeOfDay.ToString("T"));
            Console.WriteLine();
        }
    }
    public void Price()
    {
        var price = test.CallPriceTotal();
        Console.WriteLine("Your invoice: {0:C2}",price);
    }
    public void RemoveLongestCall()
    {
        Call longestCall = new Call("0200154565", 240, DateTime.Now.AddDays(1), DateTime.Now.AddHours(5));
        test.AddRemoveCall(longestCall, false);
    }
    public void ClearHistory()
    {
        test.ClearAllCalls();
    }
}

