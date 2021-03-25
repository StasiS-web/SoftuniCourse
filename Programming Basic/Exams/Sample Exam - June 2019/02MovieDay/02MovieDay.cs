using System;

namespace _02MovieDayJune2019
{
    class Program
    {
        static void Main(string[] args)
        {
            int photoTime = int.Parse(Console.ReadLine());
            int sceneCount = int.Parse(Console.ReadLine());
            int durationScene = int.Parse(Console.ReadLine());

            double prepareTime = photoTime * 0.15;
            double sceneTime = sceneCount * durationScene;
            double totalTime = prepareTime + sceneTime;

            if(photoTime >= totalTime)
            {
               double leftTime = photoTime - totalTime;
               Console.WriteLine($"You managed to finish the movie on time! You have {Math.Round(leftTime)} minutes left!");
            }
            else
            {
                double neededTime = totalTime - photoTime;
                Console.WriteLine($"Time is up! To complete the movie you need {neededTime} minutes.");
            } 
        }
    }
}
