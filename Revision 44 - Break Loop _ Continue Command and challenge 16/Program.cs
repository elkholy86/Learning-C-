using System;

namespace Revision_44___Break_Loop___Continue_Command_and_challenge_16
{
    class Program
    {
        static void Main(string[] args)
        {


            for (int i = 0; i <= 10; i++)
            {
                if (i == 7)
                        continue;
                    for (int j= 0; j<= 10; j++)
                {
                    int z = i * j;
                    Console.WriteLine($"{i} * {j} = {z}") ;
                }
            }


            //for (int i = 0; i <= 5; i++)
            //{
            //    Console.WriteLine("Hello maxpaye");
            //    if (i > 2)
            //        continue;
            //    for (int j= 0; j <= 4; j++)
            //    {
            //        Console.WriteLine("Hello world");
            //    }
            //    Console.WriteLine("\n");
            //}
            //Console.ReadKey();
        }
    }
}
