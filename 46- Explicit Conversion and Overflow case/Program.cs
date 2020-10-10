using System;

namespace _46__Explicit_Conversion_and_Overflow_case
{
    class Program
    {
        static void Main(string[] args)
        {
            byte mysbyte;
            int myint = 350;
           // mysbyte = myint;
            mysbyte = (byte)myint;
            Console.WriteLine($"My variable int = {myint}" + "\n");
            Console.WriteLine($"My Sbyte variable = {mysbyte}" + "\n");
            Console.ReadKey();
        }
    }
}
