using System;

namespace IPT_Lab1_Q3
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter number of rows: ");
            string rawInput = Console.ReadLine();
            if(int.TryParse(rawInput, out int nrows) == false)
            {
                throw new ApplicationException("Enter a valid integer.");
            }
            if(nrows < 1)
            {
                throw new ApplicationException("Number of rows must be greater than 0.");

            }

            Console.Write("Enter number of columns: ");
            rawInput = Console.ReadLine();
            if (int.TryParse(rawInput, out int ncols) == false)
            {
                throw new ApplicationException("Enter a valid integer.");
            }
            if (ncols < 1)
            {
                throw new ApplicationException("Number of columns must be greater than 0.");

            }

            int[,] randomMatrix = GenerateRandomMatrix(nrows, ncols);

            int sumOfLeftDiagonal = SumLeftDiagonal(randomMatrix, nrows, ncols);

            Console.WriteLine($"Sum of left diagonal is: {sumOfLeftDiagonal}");

        }

        static int[,] GenerateRandomMatrix(int rows, int columns, int lowerBound=0, int upperBound=100)
        {

            int[,] matrix = new int[rows, columns];

            /// Pseudo-random number generator
            Random random = new Random();

            for (int row = 0; row < rows; ++row)
            {
                for (int col = 0; col < columns; ++col)
                {
                    matrix[row, col] = random.Next(lowerBound, upperBound);
                }
            }

            return matrix;
        }

        static int SumLeftDiagonal(int[,] matrix, int rows, int columns)
        {
            int sum = 0;
            for (int row = 0; row<rows; ++row)
            {
                for (int col = 0; col<columns; ++col)
                {
                    if (row == col) sum += matrix[row, col];
                }
            }

            return sum;
        }
    }
}
