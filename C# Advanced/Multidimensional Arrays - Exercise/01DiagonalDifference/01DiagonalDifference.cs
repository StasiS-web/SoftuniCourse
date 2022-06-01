using System;
using System.Linq;

namespace _01DiagonalDifference
{
    public class DiagonalDifference
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[,] matrix = new int[n, n];
            FillMatrix(matrix);

            int sumPrimaryDiagonal = 0;
            int sumSecondaryDiagonal = 0;

            for(int row = 0; row < n; row++)
            {
                for(int col = 0; col < n; col++)
                {
                    if(row == col)
                    {
                        sumPrimaryDiagonal += matrix[row, col];
                    }
                    
                    if((row + col) == (n - 1))
                    {
                        sumSecondaryDiagonal += matrix[row, col];
                    }
                }
            }

            int difference = Math.Abs(sumPrimaryDiagonal - sumSecondaryDiagonal);
            Console.WriteLine(difference);
        }

        private static void FillMatrix(int[,] matrix)
        {
           for(int row = 0; row < matrix.GetLength(0); row++)
           {
                int[] rowData = Console.ReadLine()
                        .Split(" ")
                        .Select(int.Parse)
                        .ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = rowData[col];
                }
           }
        }
    }
}
