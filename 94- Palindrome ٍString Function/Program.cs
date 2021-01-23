using System;

namespace _94__Palindrome_ٍString_Function
{
    class Program
    {
        public static bool mypalindromefunction(string value)
        {
            // 94- Palindrome ٍString Function
            int min = 0;
            int max = value.Length - 1;
            while (true)
            {
                if (min > max)
                {
                    return true;
                }
                char a = value[min];
                char b = value[max];
                if (char.ToLower(a) != char.ToLower(b))
                {
                    return false;
                }
                min++;
                max--;

            }
        }
        static void Main(string[] args)
        {
            string[] myarray = { "Civic" , "Deified" , "Deleveled" , "perls" , "is" , "Not" , "A" , "palindrom" , ""};
            foreach (string word in myarray)
            {
                Console.WriteLine("{0} = {1}" ,word , mypalindromefunction(word));
            }
            Console.ReadKey();
        }
    }
}
