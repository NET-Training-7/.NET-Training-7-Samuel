using System;

class OilEngineVehicle : Vehicle
{
    internal float engineCapacityInCC;
    public OilEngineVehicle(string type,
    string model, 
    string vendor,
    byte wheels,
    float mileage,
    string vehicleNumber,
    float cc) :
    base(type: type,
    model: model,
    vendor: vendor,
    wheels: wheels,
    mileage: mileage,
    vehicleNumber: vehicleNumber)
    {
        this.engineCapacityInCC = cc;
    }
    internal float CalculateEnginePower() => engineCapacityInCC / 32.2f;
    internal override void PrintDetails()
    {
        base.PrintDetails();
        Console.WriteLine($"Engine power of this vehicle is {CalculateEnginePower()}");
    }
}