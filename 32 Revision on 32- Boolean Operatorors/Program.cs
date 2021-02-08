using System;

namespace _32_Revision_on_32__Boolean_Operatorors
{
    class Program
    {
        static void Main(string[] args)
        {
            //bool myresult;
            //int myvar1 = 5, myvar2 = 8;
            ////myresult = myvar1 == 6;
            ////myresult = myvar1 != 5;
            //myresult = myvar1 != 8;
            //myresult = (myvar1 <= 5) && (myvar2>8);
            //Console.WriteLine($"Myresult is = {myresult}");
            int myvar1 = 9 , myvar2 = 11 ;
            bool myresult , myresult1;
            myresult = (myvar1 < 10) && (myvar2 <= 11);
            myresult1 = (myvar1 < 10) && (myvar2 <= 11);
            Console.WriteLine($"Myresult is = {myresult}");
            Console.WriteLine($"Myresult is = {myresult1}");
            Console.ReadKey();
        }
    }
}
