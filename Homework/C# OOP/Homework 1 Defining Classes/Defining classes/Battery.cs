using System;
using System.Collections.Generic;



class Battery
{
    //Fields
    private string model;//Problem 1
    private double idleHours;
    private double talkHours;
    private TypeOfBattery batteryType;//Problem 3

    //Constructors
    public Battery(string model, double idleHours, double talkHours, TypeOfBattery batteryType)//Problem 2
    {
        this.Model = model;
        this.IdleHours = idleHours;
        this.TalkHours = talkHours;
        this.batteryType = batteryType;
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
            if (value.Length < 4 || value.Length > 20)
            {
                throw new ArgumentOutOfRangeException("Name of the model must contain between 4-20 symbols");
            }
            this.model = value;
        }
    }
    public double IdleHours//Problem 5
    {
        get
        {
            return this.idleHours;
        }
        set
        {
            if (value <= 0)
            {
                throw new ArgumentOutOfRangeException("Value cannot be less then or equal to 0");
            }
            this.idleHours = value;
        }
    }
    public double TalkHours//Problem 5
    {
        get
        {
            return this.talkHours;
        }
        set
        {
            if (value <= 0)
            {
                throw new ArgumentOutOfRangeException("Value cannot be less then or equal to 0");
            }
            this.talkHours = value;
        }
    }
    public enum TypeOfBattery//Problem 3
    {
        LiIon,
        LiPol,
        NiMh
    }
}

