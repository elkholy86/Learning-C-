using System;

namespace _60_ToUpper_Vs_ToLower__Trim_Functions
{
    class Program
    {
        static void Main(string[] args)
        {
            string mystring, mystring2;
            // Console.WriteLine("Please Enter your string");
            // mystring = Console.ReadLine();
            char[] mytrimchar = { 'h' , 'd' , 'i' , ' '};
            Console.WriteLine("Please Enter your string");
            mystring = Console.ReadLine();
            mystring = mystring.ToLower();
            mystring2 = mystring.Trim(mytrimchar);
            // mystring2 = mystring.ToUpper();
            //Console.WriteLine($"{mystring2}");
            //mystring2 = mystring.ToLower();
            // Console.WriteLine($"{mystring2}");
           // mystring2 = mystring.Trim();
            Console.WriteLine($"{mystring2}");
            Console.ReadKey();
        }
    }
}
