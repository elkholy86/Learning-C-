using System;

namespace Revision_12___21___22___23
{
    class Program
    {
        static void Main(string[] args)
        {
            //float flmin = float.MinValue;
            //float flmax = float.MaxValue;
            //Console.WriteLine($"Min value = {flmin} , max value = {flmax}");
            //float flvar = 1f / 3;
            //double dlvar = 1d / 3;
            //decimal dcvar = 1m / 3;
            //Console.WriteLine($"Float value = {flvar} , double value = {dlvar}, decimal value = {dcvar}") ;
            int charmin = char.MinValue;
            int charmax = char.MaxValue;
            int myvar = 'A';
            char myvarvalue3 = Convert.ToChar(myvar);
            Console.WriteLine($"character value = {myvar}");
            int myvarvalue = 'G';
            char myvarvalue2 = Convert.ToChar(75);
            Console.WriteLine($"Min char = {charmin} , max char= {charmax}, My character = {myvar} , myvariable number = {myvarvalue} , My conversion = {myvarvalue2}");
            string mystring = "This is my variable";
            Console.WriteLine($"My string is = {mystring}");
            bool mybool = false;
            Console.WriteLine($"my boolean value is {mybool}");
            Console.ReadKey();
        }
    }
}
