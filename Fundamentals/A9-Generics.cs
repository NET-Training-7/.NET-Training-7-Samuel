using System;
class Generics<U>
{
    public void Print<T>(T x)
    {
        Console.WriteLine($"Printing given argument: {x}");
    }

    public void Greet(U message)
    {
        Console.WriteLine(message);
    }
}
