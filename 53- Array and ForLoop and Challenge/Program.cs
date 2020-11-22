using System;

namespace _53__Array_and_ForLoop_and_Challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            const int s = 5;
            int[] arr = new int[s] { 90, 20, 10, 9, 100 };
            int max = 0;
            for (int i = 0; i < 5; i++)
            {
                if (arr[i] > max)
                    max = arr[i];
            }
            Console.WriteLine($"The max value in this array = {max} ");
          //  Console.ReadKey();
            //*************************
            const int myarraysize = 5;
            int[] mynumbers = { 1, 5, 8, 9, 7 };
            int[] mynumbers2 = new int[myarraysize];
            int[] mynumbers3 = new int[myarraysize] { 1, 5, 8, 9, 7 };
            //            Console.WriteLine($"{mynumbers[3]}");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"my num {i + 1} = {mynumbers[i]}");
            }
            Console.ReadKey();
        }
    }
}
