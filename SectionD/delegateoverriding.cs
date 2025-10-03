using System;
abstract class Calculation()
{
    public delegate int Mathop(int x, int y);
    public abstract int Display(int a, int b, Mathop op);
}

class Allcalc : Calculation
{
    public override int Display(int a, int b, Mathop op)
    {
        return op(a,b);
    }

    public int add(int x, int y) { return x + y; }
    public int multiply(int x, int y) { return x * y; }
}

class Program()
{
    static void Main()
    {
        Allcalc c1 = new Allcalc();
        //Calculation.Mathop outputadd = Allcalc.add;
        //Calculation.Mathop outputmp = Allcalc.multiply;
        Calculation.Mathop outputadd = c1.add;
        Calculation.Mathop outputmp = c1.multiply;
        Console.WriteLine(c1.Display(10, 10, outputadd));
        Console.WriteLine(c1.Display(10, 20, outputmp));
    }
}