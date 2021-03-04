using System;

namespace _43___Break_Loop_Break_Command_and_challenge_15_Revision
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 10; i++)
            {
                if (i > 7)
                    break;
                    for (int j =1; j <= 10; j++)
                {
                    int y = i * j;
                    Console.WriteLine($"{i} * {j} = {y}");
                }
        
            }


            //for (int i = 0; i <= 5; i++)
            //{
            //    Console.WriteLine("Hello Nazar");
            //    //if (i > 2)
            //    //    break;
            //    for (int j = 0; j <= 4; j++)
            //    {
            //        Console.WriteLine("\t Hello World");
            //    }
            //    Console.WriteLine("\n");
            //}
        }
    }
}
