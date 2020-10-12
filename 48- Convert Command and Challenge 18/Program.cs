using System;

namespace _48__Convert_Command_and_Challenge_18
{
    class Program
    {
        static void Main(string[] args)
        {
            float fa = 45.567f;
            string st, subt;
            st = Convert.ToString(fa);
            subt = st.Substring(2, 4);
            Console.WriteLine($"My string variable is {st} \n");
            Console.WriteLine($"My string variable is {fa} \n");
            Console.WriteLine($"My string variable is {subt} \n");
            //double mydoublevar = 2500.45d;
            //string mystringvar, mysubstring;
            //mystringvar = Convert.ToString(mydoublevar);
            //mysubstring = mystringvar.Substring(0 ,2);
            //Console.WriteLine($"My string variable is {mydoublevar} \n");
            //Console.WriteLine("My string variable is {0} \n", mystringvar);
            //  // Console.WriteLine($"My string variable is {mysubstring} \n");
            //Console.ReadKey();
        }
    }
}
