using System;
public partial class Order
{
    public int Orderid;
    public string name;
    partial void display();

    public void Process()
    {
        Console.WriteLine($"Processing orderid {Orderid} and name {name}");
        display();
    }
}

public partial class Order
{
    partial void display()
    {
        Console.WriteLine($"{name} ordered");
    }
}
public class App
{
    public static void Main()
    {
        Order order = new Order();
        order.Orderid = 1010;
        order.name = "Jai";
        order.Process();
    }
}
