using System;

namespace _73__Delegate_Type
{
    //*** 73- Delegate Type  *************

    delegate int mynewnumber(int mynumber);
        class Program
    {
        static int myxnumber = 3;
        static int addfunct(int number)
        {
            myxnumber += number;
            return myxnumber;
        }

        static int mulfunc (int number)
        {
            myxnumber *= number;
            return myxnumber;
        }
        static void Main(string[] args)
        {
            mynewnumber n1 = new mynewnumber(addfunct);
            mynewnumber n2 = new mynewnumber(mulfunc);
            n1(4);
            Console.WriteLine($"{myxnumber}");
            n2(5);
            Console.WriteLine($"{myxnumber}");
            Console.ReadKey();
        }
    }
}
