using System;

namespace _66__Reference_values_and_challenge
{
    class Program
    {
        static void Mul (ref int fs , ref int sec )
        {
            fs*= 4;
            sec *= 4;
            Console.WriteLine($"the result is = {fs} , {sec}");
        }

        //static void multiplynum(ref int myvar)
        //{
        //    myvar *= 3;
        //    Console.WriteLine($"My Number = {myvar}");
        //}
        static void Main(string[] args)
        {
            int fnumber = 9 , snum = 10; 
            Console.WriteLine($"the numbers is = {fnumber} , {snum}");
            Mul (ref fnumber , ref snum);
            Console.WriteLine($"the numbers is = {fnumber} , {snum}");
        }
    }
}
