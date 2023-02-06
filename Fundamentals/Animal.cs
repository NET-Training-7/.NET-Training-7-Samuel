using System;
class Animal
{
    internal string name;
    internal string animalType;
    internal float age;
    internal string colour;
    internal bool pet;

    internal void DisplayAnimalDetail()
    {
        Animal obj = new();
        obj.name = "Cow";
        obj.animalType = "Herbivorous";
        obj.age = 3.5f;
        obj.colour = "Black and white";
        obj.pet = false;

        Console.WriteLine($"The name of the cow is {obj.name}");
        Console.WriteLine($"The {obj.name} is a {obj.animalType} type.");
        Console.WriteLine($"The age of the cow is {obj.age} years old.");
        Console.WriteLine($"The colour of the cow is {obj.colour}");
        Console.WriteLine($"Can {obj.name} be pet (T/F) ? --> {obj.pet}");
    }
}
