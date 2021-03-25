using System;

namespace Walking
{
    class Program
    {
        static void Main(string[] args)
        {
            //read from console & save steps into a variable
            int goalSteps = 10000;
            int allSteps = 0;

            string input = Console.ReadLine();

            while (input != "Going home")
            {
                //count the steps from the input
                int countSteps = int.Parse(input);
                
                //sum the steps
                allSteps += countSteps;

                //verify if the goal is reached
                if (allSteps >= goalSteps)
                {
                    break;
                }
                input = Console.ReadLine();
            }
             //if command become "Going home"
             if (input == "Going home")
             {
               int stepToHome = int.Parse(Console.ReadLine());
                allSteps += stepToHome;
               
            }

            //if the goal is reached
            if (allSteps >= goalSteps)
            {
                //calculate the steps after the goal is reached
                int leftSteps = allSteps - goalSteps;
                Console.WriteLine("Goal reached! Good job!");
                Console.WriteLine($"{leftSteps} steps over the goal!");
            }
            else 
            {
                //calculate the steps needed to reach the goal 
                int neededSteps = goalSteps - allSteps;
                Console.WriteLine($"{neededSteps} more steps to reach goal.");
            }
        }
    }
}
