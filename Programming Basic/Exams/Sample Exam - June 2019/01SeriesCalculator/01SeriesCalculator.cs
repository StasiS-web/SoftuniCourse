using System;

namespace _01SeriesCalculatorJune2019
{
    class Program
    {
        static void Main(string[] args)
        {
            string tvShow = Console.ReadLine();
            int season = int.Parse(Console.ReadLine());
            int episode = int.Parse(Console.ReadLine());
            double timeNoAds = double.Parse(Console.ReadLine());

            double adsTime = 0.20 * timeNoAds; //time duration for ads
            double episodeDurationIncAds = timeNoAds + adsTime; //time duration for episode with ads
            double specialEpisodeTime = season * 10;
            double totalTime = episodeDurationIncAds * episode * season + specialEpisodeTime;

            Console.WriteLine($"Total time needed to watch the {tvShow} series is {totalTime} minutes.");
        }
    }
}
