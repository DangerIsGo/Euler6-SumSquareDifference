using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SumSquareDifference
{
    class Program
    {
        static void Main(string[] args)
        {
            long SumOfTheSquares = FindSumOfTheSquares();
            long SquareOfTheSums = FindSquareOfTheSums();

            Console.WriteLine("Sum of the Squares: {0}", SumOfTheSquares);
            Console.WriteLine("Square of the Sums: {0}", SquareOfTheSums);
            Console.WriteLine("Difference between: {0}", SquareOfTheSums - SumOfTheSquares);
            Console.ReadLine();
        }

        private static long FindSumOfTheSquares()
        {
            long sum = 0;
            for (long i = 1; i <= 100; i++)
            {
                sum += (i * i);
            }
            return sum;
        }

        private static long FindSquareOfTheSums()
        {
            long sum = 0;
            for (long i = 1; i <= 100; i++)
            {
                sum += i;
            }
            return sum*sum;
        }
    }
}
