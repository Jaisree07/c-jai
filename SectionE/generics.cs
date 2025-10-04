using System;

public class generics()
{
    public static void display<T>(T value)
    {
        Console.WriteLine(value);
    }
}

class Program() 
{ 
    static void Main()
    {
        generics.display<int>(2000);
        generics.display<string>("Jai");
    }
}

