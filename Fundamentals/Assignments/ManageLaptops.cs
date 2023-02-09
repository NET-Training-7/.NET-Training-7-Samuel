using System;

class ManageLaptops : Windows
{


    // Constructor for ManageLaptops
 public ManageLaptops(string wvandor, string wmodel, int wprice,byte cgeneration) :
    base(cgeneration:cgeneration,wvandor: wvandor, wmodel: wmodel, wprice: wprice)
    {
       
    }

    internal void CalculateMacBatterLife() 
    {
        short batteryPercentage = 100;
        short lifeOf1Percent = 11;
        Console.WriteLine("The life of Macbook Pro at 100 percent = "
        +(batteryPercentage * lifeOf1Percent));
    }

    internal void CalculateWinBatterLife()
    {
        short batteryPercentage = 100;
        short lifeOf1Percent = 3;
        Console.WriteLine("The life of Macbook Pro at 100 percent = "+
        (batteryPercentage * lifeOf1Percent));
        
    }
}