using System;

namespace Revision_7
{
    class Program
    {
        static void Main(string[] args)
        {
            //            49 - Input Methods In C Sharp and Challenge 19
            String FN, LN;
            int SR;
            double tr;
            Console.WriteLine("Please Enter Your First Name");
            FN = Console.ReadLine();
            Console.WriteLine("Please Enter Your Last Name");
            LN = Console.ReadLine();
            Console.WriteLine("Please Enter Your Salary");
            SR = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please Enter Your TaxRate");
            tr = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Welcome {FN} {LN}");
            Console.WriteLine($"Your Salary per month is {SR}$");
            Console.WriteLine($"Your Salary per year without taxrate is {SR * 12}$");
            Console.WriteLine($"Your Salary per Month with taxrate is {SR - (SR * tr)}$");
            Console.WriteLine($"Your Salary per Year with taxrate is {(SR * 12) - ((SR * 12) * tr)}$");
            //string myname;
            //int myvar1, myvar2;
            //Console.WriteLine("Please enter your name \n");
            //myname = Console.ReadLine();
            //Console.WriteLine("\n Please Enter Your first Number \n");

            //myvar1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter your Entry");
            //myvar2 = Console.Read();
            //Console.WriteLine($"Hello {myname}");
            //Console.WriteLine($"You Entered The number {myvar1}");
            //Console.WriteLine($"You Entered The number {myvar2}");
            //Console.ReadKey();
            //string myname;
            //int myvar1, myvar2;
            //Console.WriteLine("Please enter your name \n");
            //myname = Console.ReadLine();
            //Console.WriteLine("\n Please Enter Your first Number \n");

            //myvar1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine($"Hello {myname}");
            //Console.WriteLine($"You Entered The number {myvar1}");
            //Console.ReadKey();
            //string myname, mystrnumber;
            //int myvar1, myvar2;
            //Console.WriteLine("Please enter your name \n");
            //myname = Console.ReadLine();
            //Console.WriteLine("\n Please Enter Your first Number \n");
            //mystrnumber = Console.ReadLine();
            //myvar1 = Convert.ToInt32(mystrnumber);
            //Console.WriteLine($"Hello {myname}");
            //Console.WriteLine($"You Entered The number {myvar1}");
            //Console.ReadKey();
            //string myname mystrnumber;
            //int myvar1, myvar2;
            //Console.WriteLine("Please enter your name \n");
            //myname = Console.ReadLine();
            //Console.WriteLine($"Hello {myname}");
            //Console.ReadKey();
            //  48 - Convert Command and Challenge 18
            //float f = 45.56f;
            //string mystringvar , mysub;
            //mystringvar = Convert.ToString(f);
            //mysub = mystringvar.Substring(2,3);
            //Console.WriteLine("My String variable is {0} \n my string variable is {1}", mystringvar, mysub);
            //double mydoublevar = 2500.45D;
            //string mystringvar, mysubstring;
            //mystringvar = Convert.ToString(mydoublevar);
            //mysubstring = mystringvar.Substring(0, 2);
            //Console.WriteLine($"My String variable is {mydoublevar} \n");
            //Console.WriteLine("My String variable is {0} \n my string variable is {1}", mystringvar, mysubstring);
            //double mydoublevar = 2500.45D;
            //string mystringvar, mysubstring;
            //mystringvar = Convert.ToString(mydoublevar);
            //Console.WriteLine($"My String variable is {0} \n", mystringvar);
            //mysubstring = mystringvar.Substring(0, 2);
            //Console.WriteLine($"My String variable is {mydoublevar} \n");
            //Console.WriteLine($"My sub String variable is {mysubstring} \n");
            //47 - Checked and Unchecked and Challenge 17
            //decimal D;
            //int myint = 10000;
            //D = unchecked((decimal)myint);
            //Console.WriteLine($"My decimal variable = {D}" + "\n");
            //Console.WriteLine($"My int variable = {myint}" + "\n");
            //byte mysbyte;
            //int myint = 350;
            //mysbyte = unchecked((byte)myint);
            //Console.WriteLine($"My variable int = {myint}" + "\n");
            //Console.WriteLine($"My byte variable = {mysbyte}" + "\n");
            //Console.ReadKey();
        }
    }
    }
