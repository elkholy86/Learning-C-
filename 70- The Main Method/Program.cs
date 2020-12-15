using System;

namespace _70__The_Main_Method
{
    class Program
    {
        static int Main(string[] args)
        {
            // 70- The Main Method
         Console.WriteLine($"{args.Length} Command Line arguments has entered");
            foreach (string arg in args)
            {
                Console.WriteLine(arg);
            }
            Console.ReadKey();
            return 0;
        }
    }
}
