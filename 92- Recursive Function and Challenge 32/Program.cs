using System;
using static System.Console; 

namespace _92__Recursive_Function_and_Challenge_32
{
    class Program
    {
        static int fn(int value, ref int counter)
        {
            counter++;
            if (value == 0)
            { 
                return 1;
            }
            else
            {
               
                return value * fn(value- 1 , ref counter);
            }
        }
        //static int MyrecursiveFunction(int myvalue, ref int counter)
        //{
        //    counter++;
        //    if (myvalue == 0)
        //        return 0;
        //    else if (myvalue < 10)
        //    {
        //        return MyrecursiveFunction(myvalue + 1, ref counter);
        //    }
        //    return myvalue;
        //}
        static void Main(string[] args)
        {
         int counter = 0, theresult;
           theresult = fn(5, ref counter);
            Console.WriteLine($"My Result is {theresult} and counter is {counter}");
            ReadKey();
        }
    }
}
