using System;

namespace _03PassedOrFailed
{
    class Program
    {
        static void Main(string[] args)
        {
                double grades = 0.0;
                double.TryParse(Console.ReadLine(), out grades);

                if (grades >= 3.00)
                {
                Console.WriteLine("Passed!");
                
                }
                else 
                {
                Console.WriteLine("Failed!");
            }
        }
    }
}
