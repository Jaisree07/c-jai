using System;
//constructor chaining
class Student
{
    public string Name;
    public int Age;
    public string Course;
    public Student() : this("Unknown")   
    {
        Console.WriteLine("Constructor1");
    }
    public Student(string name) : this(name, 18, "Not Assigned")   
    {
        Console.WriteLine("Constructor2");
    }
    public Student(string name, int age, string course)
    {
        Name = name;
        Age = age;
        Course = course;
        Console.WriteLine("Constructor3");
    }
    public void Show()
    {
        Console.WriteLine($"Name:{Name},Age:{Age},Course:{Course}");
    }
}

class Program
{
    static void Main()
    {
        Student s1 = new Student();   
        Student s2 = new Student("Sree");   
        Student s3 = new Student("Jai", 21, "C#");   
        s1.Show();
        s2.Show();
        s3.Show();
    }
}
