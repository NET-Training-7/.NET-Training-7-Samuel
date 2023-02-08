public class A   // Parent|Base|Super class
{

    // Below are called Members of a class: Methods, Fields, Properties
    public int x;
    public void Do()
    {

    }
}

public class B : A     // Child|Derived|Sub class B e.g of Single-inheritance: A->
{
    public int y;
}

class C : B            // Multi-level inheritance A->B->C
{
    public int z;
}

interface ID
{
    public void T();
}

class E:A,ID
{
    public void T()
    {

    }
}

class Test123
{
    void Test1()
    {
        B b = new();
        A a = new();

        b.Do();        // here object of class B can access the method and variable(x) of class A 
        b.x = 12;
    }
}