using System;

namespace Fishland
{
    class Program
    {
        static void Main(string[] args)
        {
            double spratPrice = double.Parse(Console.ReadLine());
            double horseMackerelPrice = double.Parse(Console.ReadLine());
            double palamudKg = double.Parse(Console.ReadLine());
            double horseMackerelKg = double.Parse(Console.ReadLine());
            int shellKg = int.Parse(Console.ReadLine());

            double palamudPrice = spratPrice + spratPrice * 0.60;
            double palamudSum = palamudPrice * palamudKg;
            horseMackerelPrice = horseMackerelPrice + horseMackerelPrice * 0.80;
            double horseMackerelSum = horseMackerelPrice * horseMackerelKg;
            double shellSum = 7.50 * shellKg;

            double totalSum = palamudSum + horseMackerelSum + shellSum;

            Console.WriteLine($"{totalSum:F2}");
        }
    }
}
