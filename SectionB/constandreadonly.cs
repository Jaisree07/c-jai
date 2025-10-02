using System;

public class Circle
{
    public const double pi = 3.14159;
    public readonly double radius;

    public Circle(double r)
    {
        radius = r; 
    }
    public double Circumference()
    {
        return 2 * pi * radius;
    }
    public double Area()
    {
        return pi * radius * radius;
    }
}

public class App
{
    public static void Main()
    {
        Circle c1 = new Circle(5);  //readonly by using constructor
        Console.WriteLine(Circle.pi);     //const pi value   
        Console.WriteLine(c1.Circumference());
        Console.WriteLine(c1.Area());
    }
}
