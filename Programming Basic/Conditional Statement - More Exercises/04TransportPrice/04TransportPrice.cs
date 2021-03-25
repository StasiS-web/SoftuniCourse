using System;

namespace TransportPrice
{
    class Program
    {
        static void Main(string[] args)
        {
            int distanceKm = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();

            if (input == "day")
            {
                if (distanceKm >= 20 && distanceKm <= 99)
                {
                    //bus - day/night = 0.09 - used for distance minimum 20km
                    double busPrice = distanceKm * 0.09;
                    Console.WriteLine($"{busPrice:F2}");
                }
                else if (distanceKm >= 100)
                {
                    //train day/night = 0.06 - used for distance minimum 100km
                    double trainPrice = distanceKm * 0.06;
                    Console.WriteLine($"{trainPrice:F2}");
                }
                else
                {
                    //taxi - start = 0.70 - day = 0.79 - night = 0.90
                    double  taxiPrice = 0.70 + distanceKm * 0.79;
                    Console.WriteLine($"{taxiPrice:F2}");
                }  
            }
            else if (input == "night")
            {
                if(distanceKm >= 20 && distanceKm <= 99)
                {
                    //bus - day/night = 0.09 - used for distance minimum 20km
                    double busPrice = distanceKm * 0.09;
                    Console.WriteLine($"{busPrice:F2}");
                }
                else if (distanceKm >= 100)
                {
                    //train day/night = 0.06 - used for distance minimum 100km
                    double trainPrice = distanceKm * 0.06;
                    Console.WriteLine($"{trainPrice:F2}");
                }
                else
                {
                    double taxiPrice = 0.70 + (distanceKm * 0.90);
                    Console.WriteLine($"{taxiPrice:F2}");
                }
            } 
        }
    }
}
