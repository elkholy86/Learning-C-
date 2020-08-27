using System;

namespace _39_40_41___Loops_and_Challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            int msalary = 1000, total = 0;
            for (int i = 0; i < 12; i++)
            {
                total += msalary;
            }
            Console.WriteLine("my salary {0}" , total);
            Console.ReadKey();
            //double exlose = 1 , total = 120;
            //int i = 0;
            //while (i < 37)
            //{
            //    i++;
            //    total -= exlose;
            //    Console.WriteLine("i {0}", i);
            //}
            //Console.WriteLine("total {0}", total);
            /*****************/
            //int i = 0;
            //double msalary = 1020.30, total = 0.0;
            //while (i < 15)
            //{
            //    total += msalary;
            //    i++;
            //}
            //Console.WriteLine("My salary is {0}", total);
            //Console.ReadKey();
            // double msalary = 20 , total = 1020;
            //int i = 0;
            // do
            // {
            //     total= total+ msalary;
            //     i++;
            //     Console.WriteLine("my salary per month equal {0} {1}", total , i );
            // } while (i < 49);
            // Console.WriteLine("salary per year equal {0} ", total);
            // Console.ReadKey();
            //double msalary = 1000.20 , total = 0.0;
            //     int i = 0;
            //     do
            //     {
            //         total += msalary;
            //         i++;
            //         Console.WriteLine("I values equal {0} " , i);
            //     } while (i<10);
            //     Console.WriteLine("salary values equal {0} ", total);
            //     Console.ReadKey();
        }
    }
}
