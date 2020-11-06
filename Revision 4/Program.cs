using System;

namespace Revision_4
{
    class Program
    {
        static void Main(string[] args)
        {
            //34 , 35  - Nested If Else Statement
            int myvar = 4, myvar2 = 6;
            if (myvar <= 3 && myvar2 >= 5)
            {
                Console.WriteLine("Condtition one right");
            }
            else if (myvar <= 4 && myvar2 >= 6)
            {
                Console.WriteLine("Condition two is right");
            }
            else if (myvar2 > 5)
            {
                Console.WriteLine("Condition three is right");
            }
            else
            {
                Console.WriteLine("no one of the conditions");
            }
            Console.ReadKey();

            //*********
            //int myvar1 = 10 , myvar2 = 6 , myvar3 = 8 ;
            //if (myvar1 == 10)
            //{
            //    Console.WriteLine("My var1 == 10");
            //    if ((myvar2 >=5)&&(myvar3<=9))
            //    {
            //        Console.WriteLine("The conditions are true");
            //    }
            //    else
            //    {
            //        Console.WriteLine("The conditions are false");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("myvar1 not equal 9");
            //}
            //Console.ReadKey();
            //****************************
            //int myvar1 = 9, myvar2 = 6;
            //if (myvar1 == 10)
            //{
            //    Console.WriteLine("My var1 == 9");
            //    if (myvar2 == 7)
            //    {
            //        Console.WriteLine("myvar2==7");
            //    }
            //    else
            //    {
            //        Console.WriteLine("myvar2 is not equal 7");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("myvar1 not equal 9");
            //}
            //Console.ReadKey();
        }
    }
}
