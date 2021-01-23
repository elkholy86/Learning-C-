using System;

namespace _93__Optional_Parameters_in_C_Sharp
{
    class Program
    {
        public static void printvalues(string name = "Nazae" , int myvalue = 7)
        {
            Console.WriteLine($"name = {name} number = {myvalue}");
        }
        static void Main(string[] args)
        {
            // 93- Optional Parameters in C Sharp
            string name = "Ahmed";
            int value = 15;
            printvalues();
            printvalues(name , value);
            printvalues(name : "basem" , myvalue : 6);
        }
    }
}
