using System;

public sealed class Logger
{
    private static readonly Logger _instance = new Logger();
    private Logger() { }
    public static Logger Instance => _instance;
    public void Log(string message)
    {
        Console.WriteLine($"Log:{message}");
    }
}

class Program
{
    static void Main()
    {
        // Accessing singleton instance
        Logger.Instance.Log("This is a thread-safe log message");
        Logger.Instance.Log("Same instance used again");
    }
}
