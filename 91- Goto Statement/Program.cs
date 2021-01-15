using System;
using static System.Console;

namespace _91__Goto_Statement
{
    //  91- Goto Statement
    class Program
    {
        //static int myfunction()
        //{
        //    int counter = 0;
        //    for (int i = 0; i < 10 ; i++)
        //    {
        //        for (int j = 0; j < 10; j++)
        //        {
        //            if (j == 5)
        //            {
        //            //    goto max;

        //            }
        //            counter++;
        //        }
        ////    max:
        //        continue;
        //    }
        //    return counter;
        //}

        static void Main(string[] args)
        {
            //  WriteLine(myfunction());
            int counter = 0;
            // mylable2:
            if (counter < 10)
            {
                counter++;
                //  goto mylable2;
            }
            else
            {
                WriteLine("Done");
                WriteLine(counter);

            }
            ReadKey();
        }
       
    }
}
