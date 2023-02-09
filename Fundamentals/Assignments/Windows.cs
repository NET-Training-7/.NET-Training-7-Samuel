using System;
class Windows : Laptop
{
    byte generation;

    public Windows(string wvandor, string wmodel, int wprice, byte cgeneration) :
    base(cvandor: wvandor, cmodel: wmodel, cprice: wprice)
    {
        this.generation = cgeneration;
    }
}