using System;
using static System.Console;

namespace _85__Lambda_Expression_and_Challenge_30
{
   // delegate int MyNewNumber(int myNumber);
  
    class Program
    {
        //static int myNumber = 3;
        //static int addfunct(int number)
        //{
        //    myNumber += number;
        //    return myNumber;
        //}
        //static int mulFunc (int number)
        //{
        //    myNumber *= number;
        //    return myNumber;
        //}
        static void Main(string[] args)
        {

            Func<int, bool> func2 = (x=>x>10);
            int[] myarray = { 1 , 4 , 7 , 8 , 9 , 8 , 10 , 11 , 23 , 15};
            
            for (int i = 0; i < myarray.Length; i++)
            {
                Write($"\n The number greater 10 is {myarray[i]} {func2.Invoke(myarray[i])}");
            }
            //MyNewNumber n = x => x + myNumber;
            //MyNewNumber n1 = x => x * myNumber;

            //Func<int, bool> fun2 = (x=> x%2!=0);
            //int[] myarray = { 1 , 2 , 3 , 4 , 5 , 6};
            //for (int i = 0; i < myarray.Length; i++)
            //{
            //    WriteLine(fun2.Invoke(myarray[i]));
            //}
            //MyNewNumber n;
            //MyNewNumber n1 = new MyNewNumber(addfunct);
            //MyNewNumber n2 = new MyNewNumber(mulFunc);
            //Console.Write($"n = {n1(3)}\n");
            //n1(4);
            //Console.Write($"{myNumber}\n");
            //n1(5);
            //Console.Write($"{myNumber}\n");
            //n = n1 + n1;
            //n(5);
            //*****************
            //MyNewNumber n = x => x + myNumber;
            //MyNewNumber n1 = x => x * myNumber;
            //Write($"MyXnumber = {n(3)}\n");
            //Write($"MyXnumber = {n1(4)}\n");
        }
    }
}
