using System;

class Laptop
{
    internal string vandor;
    internal string model;
    internal int price;

    public Laptop(string cvandor, string cmodel, int cprice)
    {
        this.vandor = cvandor;
        this.model = cmodel;
        this.price = cprice;
    }

    internal virtual void PrintLaptopDetail()
    {
        Console.WriteLine($"The {model} belongs to {vandor} company." +
        $"It's price tag is {price}");
    }
}