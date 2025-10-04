using System;
using System.Collections.Generic;
public class Repository<T>
{
    private List<T> items=new List<T>();
    public void Add(T item)
    {
        items.Add(item);
    }
    public void Update(int index,T item)
    {
        items[index] = item;
    }
    public void Delete(int index)
    {
        items.RemoveAt(index);
    }
    public List<T> GetAll()
    {
        return items;
    }
}

class Program
{
    static void Main()
    {
        // Repository for strings
        Repository<string> names = new Repository<string>();
        names.Add("Jai");
        names.Add("Josh");
        names.Update(1, "Subha");  
        names.Delete(0);            
        Console.WriteLine("Names:");
        foreach (var name in names.GetAll())
        {
            Console.WriteLine(name);
        }
        // Repository for integers
        Repository<int> numbers = new Repository<int>();
        numbers.Add(100);
        numbers.Add(200);
        numbers.Update(0, 1000);   
        Console.WriteLine("\nAll numbers:");
        foreach (var num in numbers.GetAll())
        {
            Console.WriteLine(num);
        }
    }
}

