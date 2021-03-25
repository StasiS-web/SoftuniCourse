using System;

namespace HousePainting
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());

            //calculate wall area and l 
            double areaWall1 = 2 * x * y;
            double areaWall2 = 2 * x * x;
            double windows = 1.5 * 1.5 * 2;
            double door = 1.2 * 2;
            double areaForPaint1 = areaWall1 - windows;
            double areaForPaint2 = areaWall2 - door;
            double totalAreaWalls = areaForPaint1 + areaForPaint2;
            double greenPaint = totalAreaWalls / 3.4;
            //calculate roof area and l
            double areaRoof1 = x * y * 2;
            double areaRoof2 = 2 * (x * h / 2);
            double totalAreaRoof = areaRoof1 + areaRoof2;
            double redPaint = totalAreaRoof / 4.3;

            Console.WriteLine($"{greenPaint:F2}");
            Console.WriteLine($"{redPaint:F2}");
        }
    }
}
