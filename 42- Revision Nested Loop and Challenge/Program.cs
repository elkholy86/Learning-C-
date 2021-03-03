using System;
using static System.Console;

namespace _42__Revision_Nested_Loop_and_Challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            // 42- Nested Loop and Challenge


            for (int i =0; i <= 5; i +=2)
            {
                for (int n = 0; n <= 10; n++)
                {
                    int y = i * n;
                    Console.WriteLine($"{i} * {n} = {y}");
                  //  Console.WriteLine("{0} * {1} = {2}", i, n, y);
                }
            }

            //for (int i = 1; i <= 6; i += 2)
            //{
            //    for (int n = 0; n <= 10; n++)
            //    {
            //        int y = i * n;
            //        Console.WriteLine("{0} * {1} = {2}", i, n, y);
            //    }
            //}

            //for (int i = 0; i < 3 ; i++)
            //{
            //    WriteLine("\t Hello Captin");
            //    for (int j = 0; j < 2 ; j++)
            //    {
            //        WriteLine("\t Hello World");
            //    }
            //    WriteLine("\n");
            //}
            //Console.ReadKey();
        }
        }
    }
