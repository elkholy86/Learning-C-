using System;

namespace _51___Enums_Variables_and_Challenge_20
{
    class Program
    {
        //enum humansex : sbyte
        //{
        //male = 1 ,
        //femail = 2 
        //}

        enum o : sbyte
        {
            east = 2 ,
            west= 3,
            north = 4, 
            south
        }
        static void Main(string[] args)
        {

            sbyte osbyte;
            string otype;
            o MHS = o.east;
            o MHS1 = o.north;
            o MHS2 = o.south;
            o MHS3 = o.west;

            Console.WriteLine($"the orientation = {MHS}");
            osbyte = (sbyte)MHS;
            otype= Convert.ToString(MHS);
            Console.WriteLine($"Orientaion index in = {osbyte}");
            Console.WriteLine($"the Orientaion with this index seems to be = {otype}" + "\n" + "\n");

            Console.WriteLine($"the orientation = {MHS3}");
            osbyte = (sbyte)MHS3;
            otype = Convert.ToString(MHS3);
            Console.WriteLine($"Orientaion index in = {osbyte}");
            Console.WriteLine($"the Orientaion with this index seems to be = {otype}" + "\n" + "\n");

            Console.WriteLine($"the orientation = {MHS1}");
            osbyte = (sbyte)MHS1;
            otype = Convert.ToString(MHS1);
            Console.WriteLine($"Orientaion index in = {osbyte}");
            Console.WriteLine($"the Orientaion with this index seems to be = {otype}" + "\n" + "\n");

            Console.WriteLine($"the orientation = {MHS2}");
            osbyte = (sbyte)MHS2;
            otype = Convert.ToString(MHS2);
            Console.WriteLine($"Orientaion index in = {osbyte}");
            Console.WriteLine($"the Orientaion with this index seems to be = {otype}" + "\n" + "\n");

          

            //sbyte humansbyte;
            //string humangender;
            //humansex MHS = humansex.male;
            //Console.WriteLine($"Human sex = {MHS}" + "\n");
            //humansbyte = (sbyte)MHS;
            //humangender = Convert.ToString(MHS);
            //Console.WriteLine($"Human Gender index in = {humansbyte}" + "\n");
            //Console.WriteLine($"Human assoicaited with this index = {humangender}" + "\n");
        }
    }
}
