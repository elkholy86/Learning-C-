using System;

namespace _47__Checked_and_Unchecked_and_Challenge_17
{
    class Program
    {
        static void Main(string[] args)
        {
            int myint;
            decimal Elkholy = 1000;
            myint = checked((int)Elkholy);
            Console.WriteLine($"My variable int = {myint}" + "\n");
            //*************************
            //byte mysbyte;
            //int myint = 350;
            //mysbyte = unchecked((byte)myint);
            //Console.WriteLine($"My variable int = {myint}" + "\n");
            //Console.WriteLine($"My byte variable = {mysbyte}");
            //Console.ReadKey();
        }
    }
}
