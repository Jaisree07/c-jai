using System;
class AlarmClock
{
    public delegate void AlarmEventHandler(object sender, EventArgs e);
    public event AlarmEventHandler Ring;
    public void Start()
    {
        Console.WriteLine("AlarmClock: Time reached! Ringing...");
        Ring?.Invoke(this, EventArgs.Empty);
    }
}

class Person
{
    public string Name { get; set; }
    public Person(string name)
    {
        Name = name;
    }
    public void OnAlarmRing(object sender, EventArgs e)
    {
        Console.WriteLine($"{Name}");
    }
}
class Program
{
    static void Main()
    {
        // Publisher
        AlarmClock alarm = new AlarmClock();
        // Subscribers
        Person alice = new Person("Jai");
        Person bob = new Person("sree");
        // Subscribe to the event
        alarm.Ring += alice.OnAlarmRing;
        alarm.Ring += bob.OnAlarmRing;
        // Start the alarm → triggers event → notifies subscribers
        alarm.Start();
    }
}
