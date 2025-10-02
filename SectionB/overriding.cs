using System;

// Base class
public class Animal
{
    public virtual void Sound()
    {
        Console.WriteLine("Animal makes a sound");
    }
}

public class Dog : Animal
{
    public override void Sound()
    {
        Console.WriteLine("Dog barks");
    }
}

public class Cat : Animal
{
    public override void Sound()
    {
        Console.WriteLine("Cat meows");
    }
}

public class App
{
    public static void Main()
    {
        Animal a;

        a = new Dog();
        a.Sound();  

        a = new Cat();
        a.Sound();   
        // Using base class 
        Animal animal = new Animal();
        animal.Sound(); 
    }
}
