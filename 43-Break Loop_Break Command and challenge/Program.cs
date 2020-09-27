using System;

namespace _43_Break_Loop_Break_Command_and_challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 10; i++)
            {
                if (i > 6)
                    break;
                for (int n = 0; n <= 10; n++)
                {
                    int y = i * n;


                    Console.WriteLine("{0} * {1} = {2}", i, n, y);

                }
                Console.WriteLine("********************");
            }
            //for (int i = 0; i <= 5; i++)
            //{
            //    Console.WriteLine("Hello Nazar");
            //   if (i > 2)
            //        break;
            //    for (int j = 0; j <= 4; j++)
            //    {
            //        Console.WriteLine("\t Hello Nazar");
            //    }
            //    Console.WriteLine("\n");
            //}
        }
    }
}
