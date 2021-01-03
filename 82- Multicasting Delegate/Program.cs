using System;
using System.Threading.Tasks;

namespace _82__Multicasting_Delegate
{
    delegate int mynewnumber(int mynumber);
        class Program
    {
        static int myxnumber = 3;
        static int addfunct(int number)
        {
            myxnumber += number;
            return myxnumber;
        }
        static int mulfunc(int number)
        {
            myxnumber *= number;
            return myxnumber;
        }
        static void Main(string[] args)
        {
            //** 82- Multicasting Delegate **** 
            mynewnumber n;
            mynewnumber n1 = new mynewnumber(addfunct);
            mynewnumber n2 = new mynewnumber(mulfunc);
            n1(4);
            Console.Write($"{myxnumber}\n");
            n2(5);
            Console.Write($"{myxnumber}\n");
            n = n1 + n2;
            n(5);
            Console.Write($"{myxnumber}\n");
            Console.ReadKey();
        }
    }
}
