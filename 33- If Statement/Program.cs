using System;

namespace _33__If_Statement
{
    class Program
    {
        static void Main(string[] args)
        {
            int myvar1 = 10, myvar2 = 5, myvar3 = 9;
            if ((myvar1 > 10) || (myvar2 == 6) && myvar3 <= 8)
            {
                Console.WriteLine("The condition is true");
            }
            else
            {
                Console.WriteLine("The variable condition is false");
            }
            //******************************************
            //if ((myvar1 <= 11) || (myvar2 == 5) && myvar3 >= 8)
            //{
            //    Console.WriteLine("The condition is true");
            //}
            //else
            //{
            //    Console.WriteLine("The variable condition is false");
            //}
            //int myvar1 = 8;
            //if (myvar1 < 10)
            //{
            //    Console.WriteLine("My variable is greater than 10");
            //}
            //else
            //{
            //    Console.WriteLine("My variable is Less than 10");
            //}
            //int myvar1 = 10;
            //string myresult;
            //if (myvar1 < 10)
            //{
            //    myresult = "Less than 10";
            //    Console.WriteLine(myresult);
            //}
            //if (myvar1 > 10)
            //{
            //    myresult = "Greater than 10";
            //    Console.WriteLine(myresult);
            //}
            //if (myvar1 ==10)
            //{
            //    myresult = "Equal 10";
            //    Console.WriteLine(myresult);
            //}
            //****************************************************
            //int myvar = 10;
            //if (myvar == 10)
            //{
            //    myvar = 11;
            //    Console.WriteLine("{0}",myvar);
            //    Console.WriteLine("My variable equal 10");
            //}
            //else
            //    Console.WriteLine("My varible is not equal 10");
            //int myvar1 = 9, myvar2 = 7;
            //if ((myvar1 <= 9) || myvar2 >= 10)
            //{
            //    Console.WriteLine("The condition is true");
            //}
            //else
            //{
            //    Console.WriteLine("The variable condition is false");
            //}
            Console.ReadKey();        
        }
    }
}
