using System;

namespace _58_Jagged_arrays_Challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] arr = new int[3][];
            arr[0] = new int[7] { 1, 5, 8 , 9,  6 , 4 , 9 };
            arr[1] = new int[3] { 0, 4, 3 };
            arr[2] = new int[4] { 2 , 9 , 3 , 10};
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("Element ({0}) ", i);
                for (int j = 0; j < arr[i].Length; j++)
                {
                    Console.Write("{0}", arr[i][j] + " ");
                }
                Console.WriteLine();
            }
            //***** ***************
            //int[][] arr = new int[2][];
            //arr[0] = new int[5] { 1, 3, 5, 7, 9 };
            //arr[1] = new int[4] { 2 , 4 , 6 , 8};
            //for (int i = 0; i < arr.Length ; i++)
            //{
            //    Console.Write("Element ({0}) " , i);
            //    for (int j = 0; j < arr[i].Length; j++)
            //    {
            //        Console.Write("{0}" , arr[i] [j] + " ");
            //    }
            //    Console.WriteLine();
            //}
        }
    }
}
