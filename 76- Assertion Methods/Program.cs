using System;
using static System.Console;
using System.Diagnostics;

namespace _76__Assertion_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            // *** 76 - Assertion Methods ***
            WriteLine($"Enter A value");
            int i = Convert.ToInt32(ReadLine());
            if (i >= 100)
            {
                WriteLine($"{i}");
            }
            else
            {
                Debug.WriteLine("We are here");
                Debug.Assert(i >= 100 , "short" , "long");
                Trace.Assert(i >= 100, "short", "long");
            }
            WriteLine("Done");
            ReadKey();
        }
    }
}
