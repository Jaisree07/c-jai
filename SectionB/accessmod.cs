using System;

// Base class
class Person
{
    // public
    public string Name;
    // private and accessible only inside Person
    private int Age;
    // protected and used inside Person & derived classes
    protected string Address;
    // internal used in same assembly
    internal string Email;
    // protected internal used in derived classes or same assembly
    protected internal string Info; 

    public Person(string name, int age, string address, string email, string info)
    {
        Name = name;
        Age = age;
        Address = address;
        Email = email;
        Info = info;
    }
    public void ShowAge()
    {
        Console.WriteLine($"Age: {Age}");
    }
}

class Employee : Person
{
    public Employee(string name, int age, string address, string email, string info): base(name, age, address, email, info)
    {}

    public void ShowProtectedInfo()
    {
        Console.WriteLine($"Address protected: {Address}");
        Console.WriteLine($"Info protected internal: {Info}");
    }
}

class Program
{
    static void Main()
    {
        Person p = new Person("Jai", 21, "Chennai", "jai@gmail.com", "Premium");
        Console.WriteLine($"Name: {p.Name}");
        // Access private field via public method
        p.ShowAge();
        Console.WriteLine($"Email: {p.Email}");
        Console.WriteLine($"Info: {p.Info}");
        Employee e = new Employee("Subha", 21, "Coimbatore", "subha@gmail.com", "Premium");
        Console.WriteLine($"Employee Name: {e.Name}");
        Console.WriteLine($"Employee Email: {e.Email}");
        // Access protected/protected internal via derived class method
        e.ShowProtectedInfo();
    }
}
