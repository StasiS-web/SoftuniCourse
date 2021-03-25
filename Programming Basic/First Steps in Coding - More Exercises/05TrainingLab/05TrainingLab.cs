using System;

namespace TrainingLab
{
    class Program
    {
        static void Main(string[] args)
        {
            double w = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());

            double rows = (h * 100 - 100) / 70;
            double columns = w * 100 / 120;

            int totalWorkingDesk = (int) rows * (int) columns - 3;

            Console.WriteLine(totalWorkingDesk);
        }
    }
}
