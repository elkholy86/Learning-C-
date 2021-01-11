using System;
using static System.Console;

namespace _88__Params_Keyword_and_Challenge
{
    class Program
    {
        //  **** 88- Params Keyword
        static double MX (params double[] v)
        {
            double MX1 = v[0]; ;
            for (int i = 0; i < v.Length; i++)
            {
                if (MX1 < v[i])
                {
                    MX1 = v[i];
                }
            }
            return MX1;
        }
     
        //static double CalculateAverage(params double[] values)
        //{
        //    Console.WriteLine("you sent me {0} doubles.", values.Length);
        //    double sum = 0;
        //    if (values.Length == 0)
        //        return sum;
        //    for (int i = 0; i < values.Length; i++)

        //        sum += values[i];
        //    return (sum / values.Length);


        static void Main(string[] args)
        {
            //double average;
            //// we can pass arguments 
            //average = CalculateAverage(4.0, 3.2 , 5.7 , 64.22 , 87.2);
            //Console.WriteLine("Average of data is : {0}" , average);
            //// we can pass an array of doubles 
            //double[] data = { 4.0 , 3.2 , 5.7};
            //average = CalculateAverage(data);
            //Console.WriteLine("Average of data is : {0}" , average);
            //Console.WriteLine();
            //// average of 0 is 0 ! 
            //Console.WriteLine("Average of date is : {0}" , CalculateAverage());
            //Console.ReadKey();

            double Bigger, Bigger2, Bigger3 = 0;
            Bigger = MX (1.4, 2.5, 1.5, 6.3);
            WriteLine($"{Bigger}");
            double[] Bigger1 = new double[4] { 2.4, 8.5, 5.5, 6.3 };
            Bigger2 = MX(Bigger1);
            WriteLine($"{Bigger2}");
            Bigger3 = MX(Bigger3);
            WriteLine($"{Bigger3}");
        }
    }
}
