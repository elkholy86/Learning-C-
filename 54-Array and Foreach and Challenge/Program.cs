using System;

namespace _54_Array_and_Foreach_and_Challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            const int myarraysize = 15;
            int[] elements = new int[myarraysize] { 1 , 2 , 3 , 4 , 5 , 6 , 7 , 8 , 9 , 10 , 11 , 12 , 13 , 14 ,15};
            foreach (int item in elements)
            {
                if (item == elements[14])
                {
                    break;
                }
                Console.WriteLine("My Number is " + $"{item}");
            }
            Console.ReadKey();
            //********************************
            //const int myarraysize = 5;
            // int[] mynumbers3 = new int[myarraysize] { 1, 5, 8, 9, 7 };
            // //for (int i = 0; i <= 5; i++)
            // //    Console.WriteLine($"My Number {i + 1} = {mynumbers3[i]}");
            // foreach (int  item in mynumbers3)
            // {
            //     Console.WriteLine("My Number is " + $"{item}");
            // }
            // Console.ReadKey();
        }
    }
}
