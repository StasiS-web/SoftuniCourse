using System;

namespace _02Passed
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
        }
    }
}
