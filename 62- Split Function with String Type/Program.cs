using System;

namespace _62__Split_Function_with_String_Type
{
    class Program
    {
        static void Main(string[] args)
        {
            string ms;
            char[] sep = { ' '};
            ms = Console.ReadLine();
            string [] mynewwords;
            mynewwords = ms.Split(sep);
            foreach (string  word in mynewwords)
            {
                Console.WriteLine($"{word}");
            }
            Console.ReadKey();
        }
    }
}
