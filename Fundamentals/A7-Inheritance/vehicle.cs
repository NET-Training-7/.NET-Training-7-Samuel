using System;
class Vehicle 
{
    internal string vendor;
    internal string vehicleNumber;
    internal string model;
    internal string type;
    internal byte nWheels;
    internal float mileage;
    public Vehicle(string type, string model, string vendor,byte wheels,
     float mileage, string vehicleNumber)
    {
        this.type = type;
        this.vehicleNumber = vehicleNumber;
        this.model = model;
        this.nWheels = wheels;
        this.mileage = mileage;
        this.vendor = vendor; 
    }

    internal virtual void PrintDetails()
    {
        var vDetails = $"It's {nWheels} wheeler {model} {type} from {vendor} and vehicle number is {vehicleNumber} which gives {mileage} KM/litre";
        Console.WriteLine(vDetails);
    }
}
