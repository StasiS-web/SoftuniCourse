using System;

namespace WeatherForecast
{
    class Program
    {
        static void Main(string[] args)
        {
            String weather = Console.ReadLine();
            if (!weather.Equals("sunny"))
            {
                Console.WriteLine("It's cold outside!");
            }
            else
            {
                Console.WriteLine("It's warm outside!");
            }

        }
    }
}

