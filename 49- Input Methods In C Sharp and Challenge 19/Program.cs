using System;

namespace _49__Input_Methods_In_C_Sharp_and_Challenge_19
{
    class Program
    {
        static void Main(string[] args)
        {
            String FN, LN;
            int SR;
            double tr;
            Console.WriteLine("Please Enter Your First Name");
            FN = Console.ReadLine();
            Console.WriteLine("Please Enter Your Last Name");
            LN = Console.ReadLine();
            Console.WriteLine("Please Enter Your Salary");
            SR= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please Enter Your TaxRate");
            tr = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Welcome {FN} {LN}");
            Console.WriteLine($"Your Salary per month is {SR}$");
            Console.WriteLine($"Your Salary per year without taxrate is {SR*12}$");
            Console.WriteLine($"Your Salary per Month with taxrate is {SR-(SR*tr)}$");
            Console.WriteLine($"Your Salary per Year with taxrate is {(SR*12) - ((SR*12) * tr)}$");
            //string myname; char returnb;
            //int myvar1, myvar2;
            //Console.WriteLine("Please Enter Your Name \n");
            //myname = Console.ReadLine();
            //Console.WriteLine("Please Enter Your First Number\n");
            //myvar1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Please Enter Your Entry \n");
            //myvar2 = Console.Read();
            //Console.WriteLine($"Hello {myname}");
            //Console.WriteLine($"You Entered the Number {myvar1}");
            //Console.WriteLine($"You Entered the Number {myvar2}");
            //returnb = Convert.ToChar(myvar2);
            //Console.WriteLine($"You Entered the Charachter {returnb}");
            //Console.ReadKey();

            //string myname , mystrnumber ;
            //int myvar1, myvar2;
            //Console.WriteLine("Please Enter Your Name \n");
            //myname = Console.ReadLine();

            //Console.WriteLine("Please Enter Your First Number\n");
            //mystrnumber = Console.ReadLine();

            //myvar1 = Convert.ToInt32(mystrnumber);
            //Console.WriteLine($"Hello {myname}");
            //Console.WriteLine($"You Entered the Number {myvar1}");
            //Console.ReadKey();
        }
    }
}
