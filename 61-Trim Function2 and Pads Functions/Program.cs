using System;

namespace _61_Trim_Function2_and_Pads_Functions
{
    class Program
    {
        static void Main(string[] args)
        {

            string mystring = "Hello My Dear";
            Console.WriteLine("PLZ Enter your String");
         //   mystring = Console.ReadLine();
            mystring = mystring.PadRight(14, 'e');
            mystring = mystring.PadRight(15, 's');
            mystring = mystring.PadRight(16, 't');
            Console.WriteLine($"{mystring}");
            Console.ReadKey();
            //*************************
            //string mystring, mystring2;
            //char[] mytrimchar = { 'h', 'e', 'i', ' ' };
            //Console.WriteLine("PLZ Enter your String");
            //mystring = Console.ReadLine();
            //mystring = mystring.ToLower();
            //mystring2 = mystring.TrimStart(mytrimchar);
            //Console.WriteLine($"{mystring2}");
            //mystring2 = mystring.TrimEnd(mytrimchar);
            //Console.WriteLine($"{mystring2}");
            //mystring2 = mystring.PadLeft(25,'-');
            //Console.WriteLine($"{mystring2}");
            //mystring2 = mystring.PadRight(25, 'k');
            //Console.WriteLine($"{mystring2}");
            //Console.ReadKey();
        }
    }
}
