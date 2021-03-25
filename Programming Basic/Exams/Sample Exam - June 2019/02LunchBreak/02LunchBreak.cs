using System;

namespace _02LunchBreakJune2019
{
    class Program
    {
        static void Main(string[] args)
        {
            string series = Console.ReadLine();
            int episodeDuration = int.Parse(Console.ReadLine());
            int relaxDuration = int.Parse(Console.ReadLine());

            double lunchTime = relaxDuration / 8.0;
            double restTime = relaxDuration / 4.0;
            double leftTime = relaxDuration - lunchTime - restTime;

            if (leftTime >= episodeDuration)
            {
                double timeWatch = Math.Ceiling(leftTime - episodeDuration);
                Console.WriteLine($"You have enough time to watch {series} and left with {timeWatch} minutes free time.");
            }
            else
            {
                double lessTimeWatch = Math.Ceiling(episodeDuration - leftTime);
                Console.WriteLine($"You don't have enough time to watch {series}, you need {lessTimeWatch} more minutes.");
            }
        }
    }
}
