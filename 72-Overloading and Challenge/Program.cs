using System;

namespace _72_Overloading_and_Challenge
{
    class Program
    {
        public static int minvalue(int [] myarray1)
        {
            //*** 72-Overloading and Challenge ************
            int minval = myarray1[0];
            for (int i = 0; i < myarray1.Length; i++)
            {
                if (myarray1[i] < minval)
                    minval = myarray1[i];
            }
            return minval;
        }

        public static double minvalue(double minvall)
        {
            return minvall;
        }
        //public static double minvalue(double[] myarray1)
        //{
        //    double minval = myarray1[0];
        //    for (int i = 0; i < myarray1.Length; i++)
        //    {
        //        if (myarray1[i] < minval)
        //            minval = myarray1[i];
        //    }
        //    return minval;
        //}
        //public static int printname(int mynumber)
        //{
        //    return mynumber;
        //}
        //public static double printname(double mynumber)
        //{
        //    return mynumber;
        //}
        static void Main(string[] args)
        {
            int[] myarr = { 10 , 20 , 30 , 40 , 50 ,60,70,80,90};
            Console.WriteLine(minvalue(myarr));
            //int mynumber = 9;
            //Console.Write(printname(mynumber));
            //Console.ReadKey();
        }
    }
}
