using System;
using System.Collections.Generic;
using System.Text;


class GSM
{
    //Fields
    private string model;//Problem 1
    private string manufacturer;
    private string owner;
    private double price;

    private Battery battery;
    private Display display;

    private static string iPhone4S;//Problem 6

    public const double pricePerMinute = 0.37;//Problem 11/12

    public List<Call> callHistory = new List<Call>();

    //Consturctors
    public GSM(string model, string manufacturer)//Problem 2
    {
        this.model = model;
        this.manufacturer = manufacturer;
    }
    public GSM(string model, string manufacturer, string owner, double price, Battery battery, Display display)//Problem 2
    {
        this.Model = model;
        this.Manufacturer = manufacturer;
        this.Price = price;
        this.Owner = owner;
        this.battery = battery;
        this.display = display;
    }

    //Properties
    public string Model//Problem 5
    {
        get
        {
            return this.model;
        }
        set
        {
            if (value.Length < 4)
            {
                throw new ArgumentOutOfRangeException("Name must contain at least 4 symbols!");
            }
            this.model = value;
        }
    }
    public string Manufacturer//Problem 5
    {
        get
        {
            return this.manufacturer;
        }
        set
        {
            if (value.Length < 4)
            {
                throw new ArgumentOutOfRangeException("Name must contain at least 4 symbols!");
            }
            this.manufacturer = value;
        }
    }
    public string Owner//Problem 5
    {
        get
        {
            return this.owner;
        }
        set
        {
            if (value.Length < 4)
            {
                throw new ArgumentOutOfRangeException("Name must contain at least 4 symbols!");
            }
            this.owner = value;
        }
    }
    public double Price//Problem 5
    {
        get
        {
            return this.price;
        }
        set
        {
            if (value < 0)
            {
                throw new ArithmeticException("Ivalid price!");
            }
            this.price = value;
        }
    }
    public static string IPhone4S//Problem 6
    {
        get
        {
            return IPhone4S;
        }
        set
        {
            iPhone4S = value;
        }
    }
    static GSM()//Problem 6
    {
        IPhone4S = "The Iphone4S is widly know to be a very poor performing phone/n Battery life - 5min";
    }
    public List<Call> CallHistory//Problem 9
    {
        get
        {
            return callHistory;
        }
    }

    //Methods
    public override string ToString()//Problem 4
    {
        StringBuilder displayInfo = new StringBuilder();

        displayInfo.AppendLine("Manufacturer - " + this.manufacturer);
        displayInfo.AppendLine("Model - " + this.model);
        displayInfo.AppendLine("Battery model - " + this.battery.Model);
        displayInfo.AppendLine("Battery idle hours - " + this.battery.IdleHours);
        displayInfo.AppendLine("Battery talk hours - " + this.battery.TalkHours);
        displayInfo.AppendLine("Display size - " + this.display.SizeOfDisplay);
        displayInfo.AppendLine("Display colors - " + this.display.DisplayColors);
        displayInfo.AppendLine("Owner - " + this.owner);
        displayInfo.AppendLine("Price - $" + this.price);

        return displayInfo.ToString();
    }

    public void AddRemoveCall(Call newCall, bool deside)//Problem 10
    {
        if (deside == true)
        {
            callHistory.Add(newCall);
        }
        else
        {
            for (int i = 0; i < callHistory.Count; i++)
            {
                if (callHistory[i].CallDuration == newCall.CallDuration &&
                    callHistory[i].PhoneNumber == newCall.PhoneNumber) 
                {
                    callHistory.Remove(callHistory[i]);
                }
            }
        }
    }
    public void ClearAllCalls()//Problem 10
    {
        callHistory.Clear();
    }

    public double CallPriceTotal()//Problem 11
    {
        double totalMins = 0;
        foreach (var callDuration in callHistory)
        {
            totalMins += callDuration.CallDuration;
        }
        totalMins /= 60;
        double totalPrice = totalMins * pricePerMinute;
        return totalPrice;
    }
}

