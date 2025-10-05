using System;

public sealed class Printer
{
 //Private static readonly field holds the single instance
    private static readonly Printer instance=new Printer();
    private Printer()
    {
        Console.WriteLine("Printer created only once");
    }
    public static Printer Instance
    {
        get { return instance; }
    }

    public void Print(string text)
    {
        Console.WriteLine($"Printing: {text}");
    }
}

class Program
{
    static void Main()
    {
        Printer p1 = Printer.Instance;
        Printer p2 = Printer.Instance;
        p1.Print("Jai");
        p2.Print("sree");
        Console.WriteLine(Object.ReferenceEquals(p1, p2)); // True
    }
}
