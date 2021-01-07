using System;
using static System.Console;
using yb = Brothers.youngbrothers.mybrothers;
using ob = Brothers.oldbrothers.mybrothers;


namespace _84__DLL_Libraries_and_Namespaces
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Those are my Family");
            yb.print();
            ob.print();
            ReadKey();
        }
    }
}
