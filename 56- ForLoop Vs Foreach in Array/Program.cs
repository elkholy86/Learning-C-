using System;

namespace _56__ForLoop_Vs_Foreach_in_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            //****  56- ForLoop Vs Foreach in Array **************
            //string[] myfullname = { "Hossam" , "Saad" , "EL-kholy"};
            //int myarraylenght = myfullname.Length;
            // //for (int i = 0; i < myarraylenght; i++)
            // //{
            // //    myfullname[2] = "Henkesh";
            // //    Console.Write($"{myfullname[i]}" + " ");
            // //}
            // //Console.WriteLine("\nMy array lenght is " + $"{myarraylenght}");
            // foreach (string myname in myfullname)
            // {
            //     myfullname[2] = "Henkesh";
            //     //myname = "Henkesh";
            //     Console.Write($"{myname}" + " ");
            // }
            // Console.ReadKey();
            // ***** 21 - Simple DataType - FloatPointType ***************
            float flmin = float.MinValue;
            float flmax = float.MaxValue;
            Console.WriteLine("Min value = {0} max val = {1}" , flmin , flmax);

            float flvar = 1f / 3;
            double dlvar = 1d / 3;
            decimal dcvar = 1m / 3;
            Console.WriteLine("\n float value = {0} \n double value = {1} \n decimal value = {2}", flvar,dlvar,dcvar );
            Console.ReadKey();
        }
    }
}
