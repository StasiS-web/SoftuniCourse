using System;

namespace Task1ChangeBureauMarch2020
{
    class Program
    {
        static void Main(string[] args)
        {
            int countBitcoin = int.Parse(Console.ReadLine());
            double chineeseYuan = double.Parse(Console.ReadLine());
            double commision = double.Parse(Console.ReadLine());

            double bitcoin = countBitcoin * 1168;
            //1 chineese yuan = 0.15 dolars
            double dolars = chineeseYuan * 0.15;
            //1 dolar = 1.76lv.
            double leva = dolars * 1.76;
            double euro = (bitcoin + leva) / 1.95;
            double resultInEuro = euro - (commision / 100 * euro);

            Console.WriteLine($"{resultInEuro:F2}");

        }
    }
}
