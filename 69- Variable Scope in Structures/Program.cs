using System;

namespace _69__Variable_Scope_in_Structures
{
    class Program
    {
        static void Main(string[] args)
        {
            //** 69- Variable Scope in Structures
            int i, index = 0;
            for (i = 0; i < 10; i++)
            {
                index = i;
                Console.WriteLine($"{index}");
            }
            Console.WriteLine($"last index output in loop: {index}");
            Console.ReadKey();
        }
    }
}
