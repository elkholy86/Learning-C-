using System;

namespace _29_30__Revision__Increments_Decrements_Operations_Assignment_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            //int myvar1 = 5;
            //int temp1 = ++myvar1 ;
            //Console.WriteLine($"{temp1}");
            // int myvar1 = 7, myvar2 = 3;
            //  myvar2 = myvar1;
            //myvar1 += myvar2;
            // myvar2 += myvar1;
            // myvar1 -= myvar2;
            //   myvar1 %= myvar2;
            int temp, myvar1 = 7, myvar2 = 2;
            myvar1 /= ++myvar2;
            Console.WriteLine($"The result is {myvar1} and the value of var2 = {myvar2}");
        }
    }
}
