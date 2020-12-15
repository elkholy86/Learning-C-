using System;

namespace _68__Variables_Scope
{
    class Program
    {
        static string mystring2;
        static void printmystring()
        {
            string mystring = "My String inside the printmystring method";
            Console.WriteLine($"{mystring}");
            Console.WriteLine($"{mystring2}");

        }

        static void Main(string[] args)
        {
            // 68 - Variables Scope
            string mystring = "My string inside the main method";
            printmystring();
            Console.WriteLine($"{mystring}");
            Console.WriteLine($"{mystring2}");
            Console.ReadKey();


        }
    }
}
