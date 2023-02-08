using System;

class Person
{
    internal string name;
    internal byte age;

    public Person()    // Default parameterless Constructor
    {

    }

    public Person(string n, byte a)
    {
        this.name = n;
        this.age = a;
    }

}

class Test2
{
   public void T()
    {
        var p1 = new Person();
        p1.age = 23;
        p1.name = "Shyam";


        var p2 = new Person("Kishan",67);
        Console.WriteLine(p2);
        Console.WriteLine(p2.name+" "+p2.age);

    }
}