using System;
using System.Threading;

class Program
{
    static void Main()
    {
        Thread thread = new Thread(PrintNumbers);
        thread.Start();
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine($"Main Thread:{i}");
            Thread.Sleep(1000); 
        }
        thread.Join(); 
        Console.WriteLine("Main thread finished");
    }

    static void PrintNumbers()
    {
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine($"Worker Thread:{i}");
            Thread.Sleep(1500); 
        }
    }
}
