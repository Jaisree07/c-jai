using System;
using System.Threading.Tasks;

class Program
{
    static async Task<string> fetchasync()
    {
        Console.WriteLine("Fetching data...");
        await Task.Delay(3000);
        return "Data fetched successfully!";
    }
    static async Task Main()
    {
        Console.WriteLine("Program started");
        string result = await fetchasync();
        Console.WriteLine(result);
        Console.WriteLine("Program completed");
    }
}
