﻿using System;

namespace _42__Nested_Loop_and_Challenge
{
    class Program
    {
        static void Main(string[] args)
        {
           // int n = 1;
            for (int i = 1; i <= 6; i+=2)
            {
                for (int n = 0; n <= 10; n++)
                {
                    int y = i * n;
                    Console.WriteLine("{0} * {1} = {2}", i, n, y);
               }
            }
           // 1- //for (int i = 0; i < 3; i++)
            //{
            //    Console.WriteLine("Hello Nazar");
            //    for (int j = 0; j < 2; j++)
            //    {
            //        Console.WriteLine("\t Hello world");
            //    }
            //    Console.WriteLine("\n");
            //}
            //Console.ReadKey();
        }
    }
}
