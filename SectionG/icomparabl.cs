using System;
using System.Collections.Generic;
class Student : IComparable<Student>
{
    public string Name { get; set; }
    public int Age { get; set; }

    public int CompareTo(Student other)
    {
        if (other == null) return 1;
        return this.Age.CompareTo(other.Age);
    }
    public override string ToString() => $"Name: {Name}, Age: {Age}";
}

class Program
{
    static void Main()
    {
        List<Student> students = new List<Student>
        {
            new Student { Name = "Josh", Age = 22 },
            new Student { Name = "Vaish", Age = 20 },
            new Student { Name = "Subha", Age = 25 }
        };
        students.Sort(); 
        Console.WriteLine("Sorted by age");
        foreach (var student in students)
        {
            Console.WriteLine(student);
        }
    }
}
