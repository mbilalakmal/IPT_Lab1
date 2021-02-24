using System;
using System.Collections.Generic;

namespace k173669_Lab1_Q1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter an integer: ");
            string rawInput = Console.ReadLine();
            int integer;
            bool success = int.TryParse(rawInput, out integer);

            /// check if successfully parsed
            if (success == false)
            {
                throw new ApplicationException("Please enter a valid integer value.");
            }

            if (integer <= 0)
            {
                throw new ApplicationException("Please enter a positive integer.");
            }

            /// Make a list of prime numbers from 2 to integer
            List<int> primeNumbers = GetPrimeNumbersUpto(integer);
            foreach (int num in primeNumbers)
            {
                Console.WriteLine(num);
            }

            /// Wait for user input
            Console.ReadKey(true);

        }

        /// <summary>
        /// Returns prime numbers staring from 2 upto the given upperbound.
        /// upperBound must be a positive integer.
        /// </summary>
        /// <param name="upperBound"></param>
        /// <returns></returns>
        static List<int> GetPrimeNumbersUpto(int upperBound)
        {
            if (upperBound <= 0)
            {
                throw new ApplicationException("upperBound must be a positive integer.");
            }

            List<int> primeNumbers = new List<int>();

            for (int index = 0; index <= upperBound; ++index)
            {
                if (IsPrime(index)) primeNumbers.Add(index);
            }

            return primeNumbers;
        }

        /// <summary>
        /// Returns whether the given number is prime or not.
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        static bool IsPrime(int number)
        {
            if (number < 2) return false;
            int divisors = 0;
            for (int idx = 1; idx < number; ++idx)
            {
                if (number % idx == 0) ++divisors;
                if (divisors > 1) return false;
            }
            return divisors == 1;
        }

    }
}
