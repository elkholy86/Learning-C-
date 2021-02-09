using System;

namespace _33___Revision_on_If_Statement
{
    class Program
    {
        static void Main(string[] args)
        {
            // ** 33 - If Statement
            int myvar1 = 10 , myvar2 = 5 , myvar3=9;
            string myresult;
            if ((myvar1 <= 11) || (myvar2 == 5)&& (myvar3 >= 8))
            {
                myresult = "the variables is ready for view";
                Console.WriteLine(myresult);
            }
            if ((myvar1 <= 10) ||  (myvar2 == 6) && (myvar3 >= 8))
            {
                myresult = "the variables is ready for view too";
                Console.WriteLine(myresult);
            }
         


            //int myvar1 = 8;
            //string myresult;
            //if (myvar1 < 10)
            //{
            //    myresult = "less than 10";
            //    Console.WriteLine(myresult);
            //}
            //if (myvar1 > 10)
            //{
            //    myresult = "Greater than 10";
            //    Console.WriteLine(myresult);
            //}
            //if (myvar1 == 10)
            //{
            //    myresult = "Equal 10";
            //    Console.WriteLine(myresult);
            //}



            //int myvar1 = 10 ;
            //string myresult;
            //if (myvar1 < 10)
            //{
            //    myresult = "less than 10";
            //    Console.WriteLine(myresult);
            //}
            //if (myvar1 > 10)
            //{
            //    myresult = "Greater than 10";
            //    Console.WriteLine(myresult);
            //}
            //if (myvar1 == 10)
            //{
            //    myresult = "Equal 10";
            //    Console.WriteLine(myresult);
            //}


            //int myvar1 = 9 , myvar2 = 7;
            //if (myvar1 == 9 || myvar2==7)
            //{
            //    Console.WriteLine("The condition is true");
            //}
            //else
            //{
            //    Console.WriteLine("My variable conditions is false");
            //}

            //int myvar = 10;
            //if (myvar == 10)
            //{
            //    myvar = 11;
            //    Console.WriteLine($"{myvar}");
            //    Console.WriteLine("My variable equal 10");
            //}
            //else
            //    Console.WriteLine("My variable is not equal 10");


            Console.ReadKey();
        }
    }
}
