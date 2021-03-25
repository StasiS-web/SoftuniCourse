using System;

namespace _01StudentInformation
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            string age = Console.ReadLine();
            double grades = 0.0;
            double.TryParse(Console.ReadLine(), out grades);

            Console.WriteLine($"Name: {name}, Age: {age}, Grade: {grades:F2}");
        }
    }
}
