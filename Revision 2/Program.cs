using System;

namespace Revision_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string mystring = "Nazar has said This is a unique course ,and i think so";
            string mystring2 = @"Yes it's";
            string mystring3 = mystring + mystring2;
            Console.WriteLine("{0}", mystring);
            Console.ReadKey();
            //string mystring = "Nazar said This is a good course ,and i think";
            //string mystring2 = @"Yes it's";
            //string mystring3 = mystring + mystring2;
            //Console.WriteLine("{0}",mystring);
            //Console.ReadKey();
        }
    }
}
