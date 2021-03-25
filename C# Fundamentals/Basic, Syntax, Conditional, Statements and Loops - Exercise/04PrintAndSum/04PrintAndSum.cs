using System;

namespace _04PrintAndSumExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());

            int sum = 0;

            for (int i = number1; i <= number2; i++)
            {
                sum += i;
                Console.Write($"{i} ");
            }

            Console.WriteLine();
            Console.WriteLine($"Sum: {sum}"); 
        }
    }
}
