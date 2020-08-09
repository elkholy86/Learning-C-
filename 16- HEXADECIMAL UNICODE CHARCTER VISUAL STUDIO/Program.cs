using System;

namespace _16__HEXADECIMAL_UNICODE_CHARCTER_VISUAL_STUDIO
{
    class Program
    {
        static void Main(string[] args)
        {
            float flmin = float.MinValue;
            float flmax = float.MaxValue;
            Console.WriteLine("Min Value = {0} max val = {1}" ,flmin,flmax);
            float flvar = 1f / 3;
            double dlvar = 1d / 3;
            Decimal dcvar = 1m / 3;
            Console.WriteLine("\nfloat value = {0}\nDouble value = {1}\nDecimal value =   ", flvar, dlvar, dcvar);
            Console.ReadKey();
        }
    }
}
