using System;

namespace k173669_Lab1_Q7
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] string1 = new char[] { 'h', 'e', 'l', 'l'};
            char[] string2 = new char[] { 'h', 'e', 'l', 'l'};
            char[] string3 = new char[] { 'h', '3', 'l', 'l'};
            char[] string4 = new char[] { 'h', 'e', 'l', 'l', 'o'};

            Console.WriteLine($"{new string(string1)} == {new string(string2)}: {CompareStrings(string1, string2)}");
            Console.WriteLine($"{new string(string1)} == {new string(string3)}: {CompareStrings(string1, string3)}");
            Console.WriteLine($"{new string(string1)} == {new string(string4)}: {CompareStrings(string1, string4)}");

        }

        static bool CompareStrings(char[] first, char[] second)
        {
            if (first.Length != second.Length) return false;

            for(int idx = 0; idx < first.Length; ++idx)
            {
                if (first[idx] != second[idx]) return false;
            }

            return true;
        }

    }
}
