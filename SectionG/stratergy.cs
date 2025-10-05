using System;
interface behaviour
{
    void Execute();
}
class fly : behaviour
{
    public void Execute() => Console.WriteLine("flying");
}

class run : behaviour
{
    public void Execute() => Console.WriteLine("running");
}
class Animal
{
    private behaviour behavior;
    public void SetBehavior(behaviour newbehaviour)
    {
        behavior = newbehaviour;
    }

    public void PerformBehavior()
    {
        if (behavior != null)
            behavior.Execute();
        else
            Console.WriteLine("No behavior");
    }
}
class Program
{
    static void Main()
    {
        Animal dog = new Animal();
        dog.SetBehavior(new run());
        dog.PerformBehavior(); 
        dog.SetBehavior(new fly());
        dog.PerformBehavior();  
    }
}
