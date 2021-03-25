using System;

namespace PipesInPool
{
    class Program
    {
        static void Main(string[] args)
        {
            int volumOfPool = int.Parse(Console.ReadLine());
            int pipe1 = int.Parse(Console.ReadLine());
            int pipe2 = int.Parse(Console.ReadLine());
            double hours = double.Parse(Console.ReadLine());

            //calculate the pipe's water in liters
            double fullPipe1 = hours * pipe1;
            double fullPipe2 = hours * pipe2;
            double allPipes = fullPipe1 + fullPipe2;
            //calculate the percentage of the liters 
            double fullPool = (allPipes / volumOfPool) * 100.0;
            double percentPipe1 = (fullPipe1 / allPipes) * 100.0;
            double percentPipe2 = (fullPipe2 / allPipes) * 100.0;
            double extraWater = allPipes - volumOfPool;


            if (allPipes <= volumOfPool)
            {
                Console.WriteLine($"The pool is {fullPool:F2}% full. Pipe 1: {percentPipe1:F2}%. Pipe 2: {percentPipe2:F2}%.");
            }
            else
            {
                Console.WriteLine($"For {hours:F2} hours the pool overflows with {extraWater:F2} liters.");      
            }
        }
    }
}
