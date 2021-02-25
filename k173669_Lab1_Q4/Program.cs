using System;

namespace k173669_Lab1_Q4
{
    class Program
    {
        static void Main(string[] args)
        {
            double sum = Calculator.Add(1, 2, 3, 4);
            Console.WriteLine($"Calculator.Add(1, 2, 3, 4) = {sum}");

            double product = Calculator.Multiply(4, 7, 9);
            Console.WriteLine($"Calculator.Multiply(4, 7, 9) = {product}");

        }
    }
}
