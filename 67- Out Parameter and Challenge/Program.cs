using System;

namespace _67__Out_Parameter_and_Challenge
{
    class Program
    {
        static int Minvalue (int[] myarray2, out int myindex)
        {
            int minval = myarray2[0];
            myindex = 0;
            for (int i = 1 ; i < myarray2.Length ; i++)
            {
                if (myarray2[i] < minval)
                {
                    minval = myarray2[i];
                    myindex = i;
                }
            }
            return minval;
        }
        static void Main(string[] args)
        {
            int myindex;
            int[] myarray = { 1 , 10 , 43 , 6 , 22 , 8 , 9 , 13 , 50 , 22};
            int minval = Minvalue(myarray , out myindex);
            Console.WriteLine($"The Minimum value in my array is {minval} and the Index is {myindex}");
            Console.ReadKey();
        }
    }
}
