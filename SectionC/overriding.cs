using System;
class Vehicle
{
 //virtual method an can be overriden
    public virtual void Start()
    {
        Console.WriteLine("Started");
    }
}

// Derived class 1
class Car : Vehicle
{
 // Overrides the base class 
    public override void Start()
    {
        Console.WriteLine("Car Started");
    }
}

// Derived class 2
class Carbrand : Car
{
    public sealed override void Start()
    {
        Console.WriteLine("Sealed cannot be overrided");
    }
}

// Derived class 3
class Carmodel : Carbrand  // if i give vehicle means it will run and inherit and override from vehicle
{
//even i run this code,it cannot run and overide beacuse above carbrand is sealed
    //public override void Start()
    //{
    //     Console.WriteLine("carmodel");
    // }
}

class Program
{
    static void Main()
    {
        Vehicle v1 = new Vehicle();
        v1.Start();  
        Vehicle v2 = new Car();
        v2.Start(); 
        Vehicle v3 = new Carbrand();
        v3.Start();
        Vehicle v4 = new Carmodel();
        v4.Start();

    }
}
