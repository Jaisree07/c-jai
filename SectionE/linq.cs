using System;
using System.Collections.Generic;
using System.Linq;

public class Employee
{
	public int Id { get; set; }
	public string Name { get; set; }
	public string Department { get; set; }
	public int Age { get; set; }
}

class Program
{
	static void Main()
	{
		List<Employee> employees = new List<Employee>
		{
			new Employee{Id=1, Name="Jai", Department="IT", Age=21},
			new Employee{Id=2, Name="Josh", Department="HR", Age=30},
			new Employee{Id=3, Name="Vaish", Department="IT", Age=28},
		};
		var query=employees
					.Where(e => e.Age > 28)                 
					.GroupBy(e => e.Department)             
					.Select(g => new                       
					{
						Department = g.Key,Employees = g.OrderByDescending(emp => emp.Age)  
									 .Select(emp => emp.Name)          
					});
		foreach (var group in query)
		{
			Console.WriteLine($"Department: {group.Department}");
			foreach (var name in group.Employees)
			{
				Console.WriteLine($"{name}");
			}
		}
	}
}
