using Defining_classes;
using System;
using System.Collections.Generic;


class GSM_Test
{
    static void Main()
    {
        //This part test the GSM class
        GSMTest phone = new GSMTest();
        var GSM = phone.Test();
        foreach (var item in GSM)
        {
            Console.WriteLine(item);
        }
        //This part test the Call & CallHistory classes
        CallHistoryTest callHistory = new CallHistoryTest();
        callHistory.AddCalls();
        callHistory.DisplayInfo();
        callHistory.Price();
        Console.WriteLine("Loyal customer bonus - We've taken out the longes call from your invoice");
        callHistory.RemoveLongestCall();
        callHistory.Price();
        Console.WriteLine("Your phone logs have been reset");
        callHistory.ClearHistory();
        callHistory.DisplayInfo();

    }
}

