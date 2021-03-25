using System;

namespace Journey
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            switch (season)
            {
                case "summer":
                    if (budget <= 100)
                    {
                        double tripPrice = 0.30 * budget;
                        Console.WriteLine($"Somewhere in Bulgaria");
                        Console.WriteLine($"Camp - {tripPrice:f2}");
                    }
                    else if (budget <= 1000 && budget > 100)
                    {
                        double tripPrice = 0.40 * budget;
                        Console.WriteLine($"Somewhere in Balkans");
                        Console.WriteLine($"Camp - {tripPrice:f2}");
                    }
                    else if (budget > 1000)
                    {
                        double tripPrice = 0.90 * budget;
                        Console.WriteLine($"Somewhere in Europe");
                        Console.WriteLine($"Hotel - {tripPrice:f2}");
                    }
                    break;
                case "winter":
                    if (budget <= 100)
                    {
                        double tripPrice = 0.70 * budget;
                        Console.WriteLine($"Somewhere in Bulgaria");
                        Console.WriteLine($"Hotel - {tripPrice:f2}");
                    }
                    else if (budget <= 1000 && budget > 100)
                    {
                        double tripPrice = 0.80 * budget;
                        Console.WriteLine($"Somewhere in Balkans");
                        Console.WriteLine($"Hotel - {tripPrice:f2}");
                    }
                    else if (budget > 1000)
                    {
                        double tripPrice = 0.90 * budget;
                        Console.WriteLine($"Somewhere in Europe");
                        Console.WriteLine($"Hotel - {tripPrice:f2}");
                    }
                    break;  
            }
        }
    }
}
