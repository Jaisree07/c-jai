using System;
public delegate int Mathop(int x,int y);
class Program()
{
    static int add(int a,int b)
    {
        return a + b;
    }     
    static int subtract(int a,int b) { 
        return a - b; 
    }
    static void Main()
    {
        ///delegate instance creation
        Mathop out1= add;
        Mathop out2 = subtract; //assigning reference
        //invoking delegate
        Console.WriteLine(out1(10,10)); 
        Console.WriteLine(out2(10,20)); 
    }
}

