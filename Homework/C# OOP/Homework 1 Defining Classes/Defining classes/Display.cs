using System;
using System.Collections.Generic;


class Display
{
    //Fields
    private double sizeOfDisplay;//Problem 1
    private int displayColors;

    //Constructors
    public Display(double sizeOfDisplay, int displayColors)//Problem 2
    {
        this.SizeOfDisplay = sizeOfDisplay;
        this.DisplayColors = displayColors;
    }

    //Properties
    public double SizeOfDisplay//Problem 5
    {
        get
        {
            return this.sizeOfDisplay;
        }
        set
        {
            if (value <= 0)
            {
                throw new ArgumentOutOfRangeException("Value cannot be less then or equal to 0");
            }
            this.sizeOfDisplay = value;
        }
    }
    public int DisplayColors
    {
        get
        {
            return this.displayColors;
        }
        set
        {
            if (value <= 0)
            {
                throw new ArgumentOutOfRangeException("Value cannot be less then or equal to 0");
            }
            this.displayColors = value;
        }
    }
}

