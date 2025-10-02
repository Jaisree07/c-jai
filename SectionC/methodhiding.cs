using System;
class Base
{
	public void Display()
	{
		Console.WriteLine("Base Display");
	}
}

class Derived : Base
{
	public new void Display()
	{
		Console.WriteLine("Derived Display");
	}
}

class Program
{
	static void Main()
	{
		Base b = new Derived();    // Base reference, Derived object
		b.Display();               // Calls Base.Display() → because reference type is Base
		Derived d = new Derived(); // Derived reference
		d.Display();               // Calls Derived.Display() → because reference type is Derived
		Base b2 = new Base();      // Base object
		b2.Display();              // Calls Base.Display()
	}
}
