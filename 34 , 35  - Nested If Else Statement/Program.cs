using System; 

namespace _34___35____Nested_If_Else_Statement
{
    class Program
    {
        static void Main(string[] args)
        {
            int myvar = 4, myvar2 = 6;
            if (myvar <= 3 && myvar2 >= 5)
            {
                Console.WriteLine("Condition one is right");
            }
            else if (myvar <= 4 && myvar2 >= 7)
            {
                Console.WriteLine("Condition two is right");
            }
            else if (myvar2 == 5)
            {
                Console.WriteLine("Condition three is right");
            }
            else
            {
                Console.WriteLine("No one of the conditions");
            }
            //int myvar1 = 10 , myvar2 = 6 , myvar3=8;
            //if (myvar1 == 10)
            //{
            //    Console.WriteLine("My var1 equal ten");
            //    if ((myvar2 >= 5) && (myvar3 <= 9))
            //    {
            //        Console.WriteLine("Good man");
            //    }
            //}
            //****************************************
            //int myvar1 = 9, myvar2 = 6;
            //if (myvar1 == 10)
            //{
            //    Console.WriteLine("Myvar1 equal 9");
            //    if (myvar2 == 7)
            //    {
            //        Console.WriteLine("Myvar2 equal 7");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Myvar2 is not equal 7");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Myvar1 is not equal 9");
            //}
            //*************************************************
            //int myvar1 = 9, myvar2 = 6;
            //if (myvar1 == 9)
            //{
            //    Console.WriteLine("Myvar1 equal 9");
            //    if (myvar2 == 7)
            //    {
            //        Console.WriteLine("Myvar2 equal 7");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Myvar2 is not equal 9");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Myvar1 is not equal 9");
            //}
            Console.ReadKey();
        }  
    }
}
