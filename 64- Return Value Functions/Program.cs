using System;

namespace _64__Return_Value_Functions
{
    class Program
    {

        static void addnumbers(int myfirstnumbr, int mysecondnumber)
        {
            int temp = myfirstnumbr + mysecondnumber;
            Console.WriteLine($"{temp}");
        }
        static int addnumbers2(int myfirstnumbr, int mysecondnumber)
        {
            int temp = myfirstnumbr + mysecondnumber;
            return temp;
        }
        static void Main(string[] args)
        {
            int myvar1 = 5, myvar2 = 3 , temp;
         addnumbers(myvar1 , myvar2);
           // temp = addnumbers2(myvar1, myvar2);
            Console.WriteLine($"{addnumbers2(myvar1, myvar2)}");

            Console.ReadKey();
        }
    }
}
