using System;

namespace k173669_Lab1_Q2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a string: ");
            string rawInput = Console.ReadLine();

            /// check if successfully parsed
            if (string.IsNullOrWhiteSpace(rawInput))
            {
                throw new ApplicationException("Please enter a valid string.");
            }

            string answer;

            if (rawInput.Length < 5)
            {
                answer = rawInput.ToLower();
            }
            else
            {
                answer = ToLowerFourAndUpperRest(rawInput);
            }

            Console.WriteLine(answer);

            /// Wait for user input
            Console.ReadKey(true);

        }

        static string ToLowerFourAndUpperRest(string input)
        {
            string startingFour = input.Substring(0, 4).ToLower();
            string rest = input.ToUpper();

            string result = startingFour + rest.Substring(4);

            return result;
        }
    }
}
