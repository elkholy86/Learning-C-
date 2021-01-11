using System;
using static System.Console;
using System.Threading.Tasks;

namespace _87__DateTime_Type
{
    class Program
    {
        static void Main(string[] args)
        {
            // 87 - DateTime Type
            //WriteLine(DateTime.Now.ToString("hh:mm:ss \nMM dd yyyy"));
            //DateTime time = DateTime.Now;
            //string format = "MM dd yyyy h:mm";
            //WriteLine(time.ToString(format));
            //DateTime time = DateTime.Now;
            //string format = "MM ddd d hh:mm:ss yyyy";
            //WriteLine(time.ToString(format));
            //  DateTime now = DateTime.Now;
            //WriteLine(now.ToString("d"));
            //WriteLine(now.ToString("D"));
            //WriteLine(now.ToString("f"));
            //WriteLine(now.ToString("F"));
            //WriteLine(now.ToString("g"));
            //WriteLine(now.ToString("G"));
            //WriteLine(now.ToString("m"));
            //WriteLine(now.ToString("M"));
            //WriteLine(now.ToString("o"));
            //WriteLine(now.ToString("O"));
            //WriteLine(now.ToString("s"));
            //WriteLine(now.ToString("t"));
            //WriteLine(now.ToString("T"));
            //WriteLine(now.ToString("u"));
            //WriteLine(now.ToString("U"));
            //WriteLine(now.ToString("y"));
            //WriteLine(now.ToString("Y"));
            //string result = now.ToString("s ");
            // WriteLine($"{now} [s] = {result}");
            DateTime now = DateTime.Today;
            for (int i = 0; i < 7; i++)
            {
                WriteLine(now.ToString("dddd"));
                now = now.AddDays(1);
            }
        }
    }
}
