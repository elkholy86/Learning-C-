using System;
using static System.Console;
using System.Diagnostics;
namespace _74__Debugging_Mod_Vs_Release_Mod
{
    class Program
    {
        //**** 74- Debugging Mod Vs Release Mod  *****
        public static int addfunctions(int x, int y)
        {
            Debug.WriteLine("We started here in the add funtion");
            int z = x + y;
            return z;
        }
        public static int mulfunctions (int x, int y)
        {
            Debug.WriteLine("We started here in the mult funtion");
            int z = x * y;
            Debug.WriteLine("We are done here in the add funtion");
            Trace.WriteLine("We are done here in the add funtion");
            return z;
        }

        public static void writefunction (int z)
        {
            Debug.WriteLine("We started here in the write funtion");
            WriteLine($"{z}");
            Debug.WriteLine("We done here in the write funtion");
        }
        static void Main(string[] args)
        {
            int mynum, myvar1 = 4, myvar2 = 7;
            mynum = addfunctions(myvar1,myvar2);
            writefunction(mynum);
            mynum = mulfunctions(myvar1, myvar2);
            writefunction(mynum);
            ReadKey();
        }
    }
}
