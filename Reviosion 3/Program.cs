using System;

namespace Reviosion_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //            33 - If Statement

            int myvar1 = 10 , myvar2 = 5, myvar3 = 9;
            string myresult;

            if ((myvar1 <=11)||(myvar2 == 5 )&&(myvar3>=8))
            {
                myresult = "true";
                Console.WriteLine(myresult);
            }
           else
            {
                myresult = "Equal 10";
                Console.WriteLine(myresult);
            }
            if ((myvar1 <= 10) || (myvar2 ==6) && (myvar3 >= 8))
            {
                myresult = "false";
                Console.WriteLine(myresult);
            }
            //int myvar1 = 12 , myvar2 = 7;
            //string myresult;

            //if (myvar1 < 10)
            //{
            //    myresult = "My variable Less than 10";
            //    Console.WriteLine(myresult);
            //}
            //if (myvar1 > 10)
            //{
            //    myresult = "My variable is greater than 10";
            //    Console.WriteLine(myresult);
            //}
            //if (myvar1 == 10)
            //{
            //    myresult = "Equal 10";
            //    Console.WriteLine(myresult);
            //}

            //int myvar1 = 10 , myvar2=7;
            //string myresult; 

            //if (myvar1 < 10)
            //{
            //    myresult = "Less than 10"; 
            //    Console.WriteLine(myresult);
            //}
            //if (myvar1 > 10)
            //{
            //    myresult = "Greater than 10";
            //    Console.WriteLine(myresult);
            //}
            //if (myvar1 == 10)
            //{
            //    myresult = "Equal 10";
            //    Console.WriteLine(myresult);
            //}
            //            32 - Boolean Operatorors
            //bool myresult;
            //int myvar1 = 9, myvar2 = 11;
            //  myresult = (myvar1 <10) && (myvar2 <=11 );
            //myresult = (myvar1 < 10) || (myvar2 <= 11);
            //Console.WriteLine("My result is {0}", myresult);

            //bool myresult;
            //int myvar1 = 5, myvar2 = 8;
            //myresult = myvar1 != 8;
            //myresult = (myvar1 <= 5)&&(myvar2>8);
            //Console.WriteLine("My result is {0}", myresult);            
            //29,30 - Increments - Decrements Operations & Assignment Operations
            //int myvar1 = 7;
            //            inmyvar2 = 3;
            //   myvar2 = myvar1;
            //myvar1 += myvar2;
            //myvar2 += myvar1;
            //myvar1 /= ++ myvar2;
            //myvar1 %= myvar2;
            // temp = myvar1-- / ++myvar2;
            //Console.WriteLine("{0}", myvar1);
            //          Console.WriteLine("The Result is = {0} The value of var2 = {1}", myvar1, myvar2);
            //int myvar1 = 2;
            //int myvar2 = 2;
            //int temp;
            //temp = myvar1-- / ++myvar2;
            //Console.WriteLine("{0}", temp);
            //int var1= 5;
            //int temp1 = ++var1 ;
            //Console.WriteLine("{0}", temp1);
            //Console.ReadKey();
            //int myvar1 = 2;
            //int temp1 = myvar1--;
            //Console.WriteLine("{0}",temp1);
            Console.ReadKey();
        }
    }
}
