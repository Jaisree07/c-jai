using System;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        Task task1 = Task.Run(() => PrintNumbers("Task1"));
        Task task2 = Task.Run(() => PrintNumbers("Task2"));
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine($"Main Thread: {i}");
            Task.Delay(500).Wait();
        }
        Task.WaitAll(task1, task2);
        Console.WriteLine("All tasks completed");
    }

    static void PrintNumbers(string taskName)
    {
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine($"{taskName}: {i}");
            Task.Delay(500).Wait();
        }
    }
}
