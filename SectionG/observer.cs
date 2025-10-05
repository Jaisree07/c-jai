using System;
using System.Collections.Generic;
interface subscriber
{
    void Update(string message);
}
class publisher
{
    private List<subscriber> subscribers = new List<subscriber>();
    public void Subscribe(subscriber sub) => subscribers.Add(sub);
    public void Notify(string msg)
    {
        foreach (var sub in subscribers)
            sub.Update(msg);
    }
}
// Concrete Subscriber
class User : subscriber
{
    private string name;
    public User(string name) => this.name = name;
    public void Update(string message) => Console.WriteLine($"{name} received: {message}");
}
class Program
{
    static void Main()
    {
        var publisher = new publisher();
        var user1 = new User("Jai");
        var user2 = new User("Priya");
        publisher.Subscribe(user1);
        publisher.Subscribe(user2);
        publisher.Notify("Update");
    }
}
