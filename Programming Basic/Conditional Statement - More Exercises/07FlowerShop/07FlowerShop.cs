using System;

namespace FlowerShop
{
    class Program
    {
        static void Main(string[] args)
        {
            int countMagnolias = int.Parse(Console.ReadLine());
            int countHyacinths = int.Parse(Console.ReadLine());
            int countRoses = int.Parse(Console.ReadLine());
            int countCactus = int.Parse(Console.ReadLine());
            double presentPrice = double.Parse(Console.ReadLine());

            //Magnolias - 3.25lv.
            double magnoliasPrice = countMagnolias * 3.25;
            //Hyacinths - 4lv.
            double hyacinthsPrice = countHyacinths * 4;
            //Roses - 3.50lv.
            double rosesPrice = countRoses * 3.50;
            //Cactus - 8lv.
            double cactusPrice = countCactus * 8;
            double totalOrderSum = magnoliasPrice + hyacinthsPrice + rosesPrice + cactusPrice;
            //pay 5% taxFee from totalOrder
            double earningsNet = totalOrderSum - 0.05 * totalOrderSum;

            if (presentPrice <= earningsNet)
            {
                double leftMoney = Math.Floor(earningsNet - presentPrice);
                Console.WriteLine($"She is left with {leftMoney} leva.");
            }
            else if (presentPrice > earningsNet)
            {
                double neededMoney = Math.Ceiling(presentPrice - earningsNet);
                Console.WriteLine($"She will have to borrow {neededMoney} leva.");
            }
        }
    }
}
