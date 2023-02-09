class Macbook:Laptop
{
    internal string mChip;
     public Macbook(string mvandor, string mmodel, int mprice, string mChip) :
    base(cvandor: mvandor, cmodel: mmodel, cprice: mprice)
    {
        this.mChip = mChip;
    }
    internal override void PrintLaptopDetail()
    {
        base.PrintLaptopDetail();
    }
}