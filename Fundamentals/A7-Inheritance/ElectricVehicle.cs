using System;
class ElectricVehicle : Vehicle
{
    public ElectricVehicle(string type, string model, string vendor, byte wheels,
    float mileage, string vehicleNumber) :
    base(type: type,
    model: model,
    vendor: vendor,
    wheels: wheels,
    mileage: mileage,
    vehicleNumber: vehicleNumber)
    {

    }
    float batterCapacityInKw;

    float CalculateEngineinPowerHP() => batterCapacityInKw * 1.369f;
}