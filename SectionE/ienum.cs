using System;
using System.Collections;
using System.Collections.Generic;

public class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
}

public class StudentCollection : IEnumerable<Student>
{
    private List<Student> students = new List<Student>();

    public void Add(Student student) => students.Add(student);

    public IEnumerator<Student> GetEnumerator()
    {
        foreach (var s in students)
        {
            yield return s; 
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}

class Program
{
    static void Main()
    {
        StudentCollection students = new StudentCollection();

        students.Add(new Student { Id = 1, Name = "Jai" });
        students.Add(new Student { Id = 2, Name = "Dk" });
        students.Add(new Student { Id = 3, Name = "Jeeva" });

        foreach (var student in students)
        {
            Console.WriteLine($"Id: {student.Id}, Name: {student.Name}");
        }
    }
}
