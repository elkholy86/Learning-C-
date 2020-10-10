using System;

namespace _45___Implicit_Conversion_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            long myvar = 1000;
            float myvar2 = myvar;
            Console.WriteLine($"{myvar2}");
            char myvar3 = 'G'; 
            int myintvar = myvar3;
            Console.WriteLine($"{myintvar}");
            Console.ReadKey();

        }
    }
}
