using System;

namespace _52__Structure_Type_and_Challenge
{
    class Program
    {
        enum o : sbyte
        {
            east = 1,
            west = 2,
            north = 3,
            south = 4
        }
        struct directions
        {
            public o oriantation;
            public double Distance;
        }
        //    enum toyota : byte
        //{
        //    Rav4 = 1,
        //    camery = 2,
        //    tundra = 3,
        //    highland = 4
        //}
        //    struct cartype
        //    {
        //        public toyota modelname;
        //        public double modelyear; 
        //    }

        static void Main(string[] args)
        {
            directions di ;
            int d = -1;
            double distance ;
            Console.WriteLine("1)East\n2)west\n3)North\n4)South");
            do
            {
                Console.WriteLine("Enter the directions :");
                d = Convert.ToInt32(Console.ReadLine());
            } while ((d < 1) || (d > 4));
            Console.WriteLine("the distance of the directions is : ");
            distance = Convert.ToDouble(Console.ReadLine());
            di.oriantation= (o)d;
            di.Distance = distance;
            Console.WriteLine($"The orientation is {di.oriantation}" + $" And the Distance is {di.Distance}");
            Console.ReadKey();

            //**************************
            //cartype mycartype;
            //int cartype = -1;
            //double modelyear;
            //Console.WriteLine("1) Rav\n2) camery\n3) tundra\n4) Highland ");
            //do
            //{
            //    Console.WriteLine("Enter your car type:");
            //    cartype = Convert.ToInt32(Console.ReadLine());
            //} while ((cartype < 1) || (cartype > 4));
            //Console.WriteLine("Input a modelYear : ");
            //modelyear = Convert.ToDouble(Console.ReadLine());
            //mycartype.modelname = (toyota)cartype;
            //mycartype.modelyear = modelyear;
            //Console.WriteLine($"My Car type is {mycartype.modelname}" + $" and the model year is {mycartype.modelyear}");
            //Console.ReadKey();

        }
    }
}
