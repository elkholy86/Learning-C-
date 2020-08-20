using System;

namespace _36___Switch_Statement__Challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            string whathesay = "Hello";
            switch (whathesay)
            { 
             case "hello":
                  Console.WriteLine("hello");
                break;
                case "Bye":
                    Console.WriteLine("Bye");
                    break;
                case "Welcome":
                    Console.WriteLine("Welcome");
                    break;
                default:
                  Console.WriteLine("No one");
                 break;
            }
            //************
            //int myvar = 15;
            //switch (myvar)
            //{
            //    case 10:
            //        Console.WriteLine("My variable number value is 10");
            //        break;
            //    case 15:
            //        Console.WriteLine("My variable number value is 15");
            //        break;
            //    case 4:
            //        Console.WriteLine("My variable number value is 4");
            //        break;
            //    default: 
            //        Console.WriteLine("No one");
            //        break;
            //}
            //*********************
            //string myanimal = "Cat";
            //switch (myanimal)
            //{
            //    case "canary":
            //        Console.WriteLine("My animal is the canary bird");
            //        break;
            //    case "Cat":
            //        Console.WriteLine("My animal is a cat");
            //        break;
            //    case "camel":
            //        Console.WriteLine("My animal is a camel");
            //        break;
            //    default:
            //        Console.WriteLine("No one");
            //        break;
            //}                
        }
    }
}
