using System;

namespace _44_Break_Loop_Continue_Command_and_challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 10; i++)
            {
                if (i == 11)
                    continue;
                for (int n = 0; n <= 10; n++)
                {
                    int y = i * n;


                    Console.WriteLine("{0} * {1} = {2}", i, n, y);

                }
                Console.WriteLine("********************");
            }

            //for(int i = 0; i <=5; i++)
            //{
            //    if (i > 2)
            //        continue;
            //    for (int j = 0; j <= 4; j++)
            //    {
            //        Console.WriteLine("\t hello world");
            //    }
            //    Console.WriteLine("Hello Nazar");
            //    Console.WriteLine("\n");
            //}
            //Console.ReadKey();
        }
    }
}
