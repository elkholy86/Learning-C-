using System;

namespace _37___Ternary_Condition
{
    class Program
    {
        static void Main(string[] args)
        {
            string myname = "nazar", result;
            result = (myname.Equals("Nazar")) ? "yes" : "NO";
            Console.WriteLine("My variable Result is {0}", result);
            Console.ReadKey();
            //************
            //int myvar = 9;
            //string myresult = (myvar < 10) ? "Less than 10" : "Greater than 10";
            //Console.WriteLine("My variable Result is {0}", myresult);
        }
    }
}
