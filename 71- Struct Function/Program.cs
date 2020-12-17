using System;

namespace _71__Struct_Function
{
    class Program
    {
        struct fullname 
        {
            
            
            public string myfirstname, mylastname;
            public string printname ()=> myfirstname + " " + mylastname;
        }
        static void Main(string[] args)
        {
            // 71- Struct Function 
            fullname myfullname;
            myfullname.myfirstname = "Hossam";
            myfullname.mylastname = "Elkholy";
            //            Console.Write($"{myfullname.myfirstname} {myfullname.mylastname}");
            Console.Write(myfullname.printname());
            Console.ReadKey();

        }
    }
}
