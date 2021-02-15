using System;

namespace _39_40_41___Loops_and_Challenge_11_12_13
{
    class Program
    {
        static void Main(string[] args)
        {
            double my = 120, E = 1;

            for (int i = 1; my > 83; i++)
            {
                my -= E;
                Console.WriteLine($"Your weight is {my}, And you make exercise {i}");
            }
            //while (my > 83)
            //{
            //   my-=E ;
            //    i++;
            //    Console.WriteLine($"Your weight is {my}, And you make exercise {i}");
            //}

            //double MS = 1020, I = 20;
            //for (int i = 1; MS < 2000; i++)
            //{
            //    MS += I;
            //    Console.WriteLine($"Your Salary is {MS}, And you need {i} Months to reach it");
            //}    
            //int mysalary = 1000, total = 0;
            //for (int i = 0; i < 12; i++)
            //{
            //    total += mysalary;
            //}
            //Console.WriteLine($"My Salary for 12 Months is {total}");
            //Console.ReadKey();

            //double my = 120 , E = 1;
            //int i = 0;

            //while (my > 83)
            //{
            //   my-=E ;
            //    i++;
            //    Console.WriteLine($"Your weight is {my}, And you make exercise {i}");
            //}

            //int i = 0;
            //double mysalary = 1020.30, total = 0.0;
            //while (i < 15)
            //{
            //    total += mysalary;
            //    i++;
            //}
            //Console.WriteLine($"My Salary is {total}");
            //Console.ReadKey();
            //double MS = 1020, I = 20;
            //int i = 0;
            //do
            //{
            //    MS += I;
            //    i++;
            //    Console.WriteLine($"Your Salary is {MS}, And you need {i} Months to reach it");
            //} while (MS < 2000);

            //double mysalary = 1000.20, total = 0.0;
            //int i = 0;
            //do
            //{
            //    total += mysalary;
            //    i++;
            //    Console.WriteLine($"I values equal {i}");
            //} while (i < 10);
            //Console.WriteLine($"salary values equal {total}");
            //Console.ReadKey();
        }
    }
}
