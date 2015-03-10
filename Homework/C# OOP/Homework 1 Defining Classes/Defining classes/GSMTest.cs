using System;
using System.Collections.Generic;


class GSMTest//Problem 7
{
    private GSM[] arrayOfGSM = new GSM[4];
    private string[] owners = new string[] { "Jonny", "Alex", "Tom", "Kate" };
    private string[] manufacturers = new string[] { "Trex", "Quatnum", "Parsel", "Generic" };
    private string[] models = new string[] { "Bone", "Theory", "Meter", "Trash" };
    private double[] prices = new double[] { 250, 1695.95, 860, 9.95 };
    private string[] batteriesModels = new string[] { "UltraBat", "Intelic", "DuraNotCell", "Rec" };
    private double[] idleHours = new double[] { 36, 50, 31.5, 0.30 };
    private double[] talkHours = new double[] { 12, 21, 13.5, 0.05 };
    private Battery.TypeOfBattery[] batteryType = new Battery.TypeOfBattery[] { Battery.TypeOfBattery.LiIon, Battery.TypeOfBattery.LiIon, Battery.TypeOfBattery.LiPol, Battery.TypeOfBattery.NiMh };//honestly I cant beleave this worked :D 
    private double[] size = new double[] { 5, 5.5, 3, 0.5 };
    private int[] colors = new int[] { 1600000, 256000000, 3600, 1 };

    public GSM[] Test()
    {
        for (int i = 0; i < 4; i += 1)
        {
            Battery bat = new Battery(batteriesModels[i], idleHours[i], talkHours[i], batteryType[i]);
            Display disp = new Display(size[i], colors[i]);
            arrayOfGSM[i] = new GSM(models[i], manufacturers[i], owners[i], prices[i], bat, disp);
        }
        return arrayOfGSM;
    }
}

