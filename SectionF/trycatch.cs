using System;
public class Agelowexp : Exception
{
    public Agelowexp(string message) : base(message) { }
}

class Program
{
    static void Main()
    {
        try
        {
            Console.WriteLine("Age:");
            int age = int.Parse(Console.ReadLine());
            if (age < 18)
            {
                throw new Agelowexp("Age must be 18 or above");
            }
            Console.WriteLine("Eligible");
        }
        catch (Agelowexp ex)
        {
            Console.WriteLine($"Exception Caught: {ex.Message}");
        }
        catch (FormatException ex)
        {
            Console.WriteLine($"Input Error: {ex.Message}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"General Error: {ex.Message}");
        }
        finally
        {
            Console.WriteLine("try-catch-finally block completed");
        }
    }
}
