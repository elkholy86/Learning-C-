using System;

namespace _65__MinimumValue_Function_and_challenge
{
    class Program
    {

        static double avg(int[] r)
        {
            double value = 0;
            for (int i = 0; i < r.Length; i++)
            {
                value += r[i];
            }
            value = value / 7;
            return value;
        }
        //--------------------
        static int Minvalue (int[] myarray2)
        {
            int minval = myarray2[0];
            for (int i = 0; i < myarray2.Length; i++)
            {
                if (myarray2[i] < minval)
                    minval = myarray2[i];
            }
            return minval;
        }
        static void Main(string[] args)
        {
            int[] degree = { 100, 100, 100, 100, 0, 100, 100 };
            double deg = avg(degree);
            double value = 0;
            for (int i = 0; i < degree.Length; i++)
            {
                value += degree[i];
            }
            Console.WriteLine($"The MAX AVG in the subjects is {value}");
            Console.WriteLine($"The AVG for the student is {deg}");
            //---------------
            //int[] myarray = { 11 , 10 , 3 , 6 , 2 , 8 , 9 };
            //int minval = Minvalue(myarray);
            //Console.WriteLine($"The minimum value in my array is {minval}");
            Console.ReadKey();
        }
    }
}
