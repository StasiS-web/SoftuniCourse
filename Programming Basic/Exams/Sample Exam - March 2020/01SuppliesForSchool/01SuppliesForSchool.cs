using System;

namespace Task1SuppliesForSchoolMarch2020
{
    class Program
    {
        static void Main(string[] args)
        {
            int countPencils = int.Parse(Console.ReadLine());
            int countMarkers = int.Parse(Console.ReadLine());
            double cleanningLiquidInLiters = double.Parse(Console.ReadLine());
            int discount = int.Parse(Console.ReadLine());

            //pencils - 5.80lv.
            double pencilsPrice = countPencils * 5.80;
            //markers - 7.20lv.
            double markersPrice = countMarkers * 7.20;
            //cleanningLiquid - 1.20lv.(per liter)
            double cleanningLiquidPrice = cleanningLiquidInLiters * 1.20;
            double totalSum = pencilsPrice + markersPrice + cleanningLiquidPrice;
            double totalSumWithDiscount = totalSum - ((totalSum * discount) / 100);

            Console.WriteLine($"{totalSumWithDiscount:F3}");
        }
    }
}
