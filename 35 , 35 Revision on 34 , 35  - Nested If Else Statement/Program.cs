using System;

namespace _35___35_Revision_on_34___35____Nested_If_Else_Statement
{
    class Program
    {
        static void Main(string[] args)
        {
            int myvar = 4, myvar2 = 6;
            if (myvar <= 3 && myvar2 >= 5)
            {
                Console.WriteLine("Condition one right");
            }
            else if (myvar <= 4 && myvar2 >= 6)
            {
                Console.WriteLine("Condition two right");
            }
            else if (myvar2 > 5)
            {
                Console.WriteLine("Condition three right");
            }
            else
            {
                Console.WriteLine("No one of the conditions");
            }
            //int myvar1 = 10, myvar2 = 6 , myvar3= 8;
            //if (myvar1 == 10)
            //{
            //    Console.WriteLine("Myvar1 is true");
            //    if ((myvar2 >=5) && (myvar3<=9))
            //    {
            //        Console.WriteLine("The condition is true");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Myvar2 is not equal 9");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Myvar1 not equal shela");
            //}
            //Console.ReadKey();

            //int myvar1 = 9, myvar2 = 6;
            //if (myvar1 == 10)
            //{
            //    Console.WriteLine("Myvar1 == 9");
            //    if (myvar2 == 7)
            //    {
            //        Console.WriteLine("Myvar2 == 7");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Myvar2 is not equal 9");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Myvar1 not equal 9");
            //}
            Console.ReadKey();
        }
    }
}
