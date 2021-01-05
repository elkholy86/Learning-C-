using System;
using static System.Console;
using yb= Brothers.youngbrothers.mybrothers;
using ob= Brothers.oldbrothers.mybrothers;

namespace _83__Using_Namespaces_in_Practical
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
namespace Brothers
{
    namespace youngbrothers
    {
        class mybrothers
        {
            public static void print()
            {
                Write($"Tarek and Ahmed");
            }

        }
    }

    namespace oldbrothers
    {

        class mybrothers
        {
            public static void print()
            {
                Write($"\nMohammed and shamel");
            }

        }

    }
}

