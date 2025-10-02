using System;
class Vehicle
{
    public void display()
    {
        Console.WriteLine("vehicle");
    }
}
class Car : Vehicle
{
    public void Cartype(string name)
    {
        Console.WriteLine($"Brand:{name}");
    }
}

class Program
{
    static void Main()
    {
        Car myCar = new Car();
        myCar.display();  
        myCar.Cartype("Scorpio");   
    }
}
