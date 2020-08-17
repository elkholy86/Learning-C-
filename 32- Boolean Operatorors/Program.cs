using System;

namespace _32__Boolean_Operatorors
{
    class Program
    {
        static void Main(string[] args)
        {
            bool myresult;
            int myvar1 = 9 , myvar2 = 11 ;
            //myresult = myvar1 != 8;
            myresult = (myvar1 < 10) || (myvar2 <= 11);
            Console.WriteLine("My result is = {0}" , myresult);
            Console.ReadKey();
        }
    }
}
