using System;

namespace SleepyTomCat
{
    class Program
    {
        static void Main(string[] args)
        {
            int daysOffWork = int.Parse(Console.ReadLine());

            double workDays = 365 - daysOffWork;
            double gameTime = workDays * 63 + daysOffWork * 127;

            double hours = 0;
            double minutes = 0;

            if (gameTime < 30000)
            {
                double diferanceInTime = 30000 - gameTime;
                hours = Math.Floor(diferanceInTime / 60);
                minutes = diferanceInTime % 60;
                Console.WriteLine("Tom sleeps well");
                Console.WriteLine($"{hours} hours and {minutes} minutes less for play");
               
            }
            else if(gameTime > 30000)
            {
                double extraGameTime = gameTime - 30000;
                hours = Math.Floor(extraGameTime / 60);
                minutes = extraGameTime % 60;
                Console.WriteLine("Tom will run away");
                Console.WriteLine($"{hours} hours and {minutes} minutes more for play");
            }
        }
    }
}
