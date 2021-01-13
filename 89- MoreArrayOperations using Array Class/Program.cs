using System;
using static System.Array;

namespace _89__MoreArrayOperations_using_Array_Class
{
    class Program
    {
        static void SystemArrayFunctionality()
        {
            // 89- MoreArrayOperations using Array Class
            Console.WriteLine("Working with the class System.Array");
            // Initialize items at statup
            int[] mynumbers = new[] { 11,2,31,14,5,100};
            Console.WriteLine("\n The Rank of array = {0}" , mynumbers.Rank);
            // print out numbers in declare order 
            Console.WriteLine("Here is the array :");
            for (int i = mynumbers.GetLowerBound(0); i <=mynumbers.GetUpperBound(0); i++)
            {
                // print a number 
                Console.Write(mynumbers[i] + "\n");
            }
            //sort them
            Array.Sort(mynumbers);
            Console.Write("\nThe sorted array = ");
            // and print them 
            for (int i = 0; i < mynumbers.Length; i++)
            {
                // print a number
                Console.Write(mynumbers[i] + "\n");
            }
            Console.WriteLine("\n");
            // Reverse them 
            Reverse(mynumbers);
            Console.WriteLine("\nthe reversed array = ");
            //-- and print them 
            for (int i = 0; i < mynumbers.Length; i++)
            {
                // print a number 
                Console.Write(mynumbers[i] + "\n");
            }
            Console.WriteLine("\n");
            // Clear out all but the funal member 
            Console.WriteLine("Cleared out all but ... ");
            Clear(mynumbers,0,mynumbers.Length);
            for (int i = 0; i < mynumbers.Length; i++)
            {
                // print a number 
                Console.Write(mynumbers[i] + "\n");
            }
            string[] array2 = ConvertAll(mynumbers,element=>element.ToString());
            // write string array . 
            Console.WriteLine(string.Join(";", array2));
        }

        static void Main(string[] args)
        {
            SystemArrayFunctionality();
            Console.ReadKey();

        }
    }
}
