using System;
class Vehicle
{
    public string brand;

    public void Brand()
    {
        Console.WriteLine($"Brand: {brand}");
    }
}
class Car : Vehicle
{
    public int model;

    public void Model()
    {
        Console.WriteLine($"Model: {model}");
    }
}
class SpeedCar : Car
{
    public int speed;

    public void Speed()
    {
        Console.WriteLine($"Max Speed: {speed} km/h");
    }
}

class Program
{
    static void Main()
    {
        SpeedCar car1 = new SpeedCar();
        car1.brand = "Scorpio";   
        car1.model = 2012;          
        car1.speed = 200;      
        car1.Brand();        
        car1.Model();        
        car1.Speed();      
    }
}
