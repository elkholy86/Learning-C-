using System;
using static System.Console;

namespace Revision_on_27_and_28__Mathematical_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            // Revision on 27 and 28  Mathematical Operations
            int V = 7;
            int v2 = 3;
            int v3 = V + v2;
            int v4 = V - v2;
            int v5 = V / v2;
            int v6 = V * v2;
            int v7 = V % v2;
            string w1 = "I am";
            string w2 = " Smart";
            string w = w1 + w2;
            WriteLine($"{w}");
            WriteLine($"{v3} , {v4} , {v5} , {v6} , {v7}");
            int myvar1 = 15;
            int myvar2 = 10;
            int temp = myvar1 + myvar2;
            int temp2 = myvar1 - myvar2;
            int temp3 = myvar1 % myvar2;
            int mynegtivevar = -10;
            int temp4 = +myvar1;
            int temp5 = -myvar1;
            int temp6 =  +mynegtivevar;
            string mystr = "This is wonderful";
            string mystr2 = " How is it ? ";
            mystr = mystr + mystr2;
            Write($"{mystr}\n");
            WriteLine($"The result is {temp4}, The result 2 is {temp5}, The result 2 is {temp6}");
            WriteLine($"The result is {temp4}, The result 2 is {temp5}, The result 2 is {temp6}");
            // WriteLine($"The result is {temp}, The result 2 is {temp2} and the result3 is {temp3}");
            ReadKey();
        }
    }
}
