using System;
//#define PI=3.14567
//#undef test
abstract class Shape
{
    //implemented by derived classes
    public abstract double Calculate();
    // Concrete method 
    public void Display()
    {
        Console.WriteLine($"Area: {Calculate()}");
    }
}

class Circle:Shape
{
    public double rad;

    public Circle(double radius)
    {
        rad = radius;
    }
    public override double Calculate()
    {
        return Math.PI*rad*rad;
    }
}

class Rectangle:Shape
{
    public double Length;
    public double Width;

    public Rectangle(double length, double width)
    {
        Length = length;
        Width = width;
    }
    public override double Calculate()
    {
        return Length*Width;
    }
}

class Program
{
    static void Main()
    {
        Shape circle = new Circle(10);
        circle.Display();  
        Shape rectangle = new Rectangle(18, 12);
        rectangle.Display(); 
    }
}
