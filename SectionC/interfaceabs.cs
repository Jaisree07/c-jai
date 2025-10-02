using System;
public interface IShape
{
    double CalculateArea();       
    double CalculatePerimeter(); 
}
public abstract class Shape
{
    public string Name { get; set; } 
    public abstract double CalculateArea();   
    public virtual void Display()          
    {
        Console.WriteLine($"{Name} Area: {CalculateArea()}");
    }
}
//interface + inherits abstract class
public class Circle : Shape, IShape  
{
    public double Radius { get; set; }
    public Circle(double radius)
    {
        Radius = radius;
        Name = "Circle";
    }
    public override double CalculateArea()
    {
        return Math.PI * Radius * Radius;
    }

 // From interface
    public double CalculatePerimeter()
    {
        return 2 * Math.PI * Radius;
    }
}

class Program
{
    static void Main()
    {
        IShape c1 = new Circle(5);
        Console.WriteLine($"Circle Perimeter: {c1.CalculatePerimeter()}");
// Abstract class reference
        Shape s1 = new Circle(5);
        s1.Display();
    }
}
