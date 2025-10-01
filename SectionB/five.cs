// #define DEBUG
#undef TEST

using System;

class Program
{
    static void Main()
    {
#if DEBUG
        Console.WriteLine("Debug");
#endif

        #region Greeting Methods
        a();
        b();
        #endregion

#pragma warning disable CS0168
        int unusedvar;
#pragma warning restore CS0168
    }

    #region Methods
    static void a()
    {
        Console.WriteLine("hello");
    }

    static void b()
    {
        Console.WriteLine("hai");
    }
    #endregion
}
