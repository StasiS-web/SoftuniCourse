using System;
using System.Linq;

namespace _01SumMatrixElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sizes = ReadArray();
            int[,] matrix = new int[sizes[0], sizes[1]]; //initilized the matrix

            //create the matrix
            for (int row = 0; row < sizes[0]; row++)
            {
                int[] columnElements = ReadArray(); //get the element from the columns

                for (int col = 0; col < sizes[1]; col++)
                {
                    matrix[row, col] = columnElements[col];
                }
            }

            Console.WriteLine(matrix.GetLength(0));
            Console.WriteLine(matrix.GetLength(1));

            //Sum of all matrix elements
            int sum = 0;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    sum += matrix[row, col];
                }
            }

            Console.WriteLine(sum);
        }

        //Method for reading from the console
        private static int[] ReadArray()
        {
            return Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
        }
    }
}
