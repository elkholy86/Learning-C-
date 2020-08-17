using System;

namespace _29_30___Increments___Decrements_Operations__Assignment_Oper
{
    class Program
    {
        static void Main(string[] args)
        {
           int temp,  myvar1 = 7, myvar2 = 2;
            //myvar1 = myvar2;
            //myvar1 -= myvar2;
           temp =  myvar1 /= ++myvar2;
            Console.WriteLine("The result is = {0}", temp);
            //***********************************************************
            //int temp1, myvar1 = 5, myvar2 = 2;
            //temp1 = myvar1-- / ++myvar2;
            //Console.WriteLine("{0}", temp1);
            //Console.ReadKey();
        }
    }
}
