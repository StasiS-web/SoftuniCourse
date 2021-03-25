using System;
using System.Linq;

namespace _02TheLift
{
    class Program
    {
        static void Main(string[] args)
        {
            int peopleWaiting = int.Parse(Console.ReadLine());
            int[] wagon = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int peopleCurrentWagon = 0;
            int peopleOnTheLift = 0;
            bool NoPeople = false;

            //finds a place for the tourist on a lift
            for (int i = 0; i < wagon.Length; i++)
            { //every wagon should have a maximum of 4 people
                while (wagon[i] < 4)
                {
                    wagon[i]++;
                    peopleCurrentWagon++;

                    int wagonPeople = peopleOnTheLift + peopleCurrentWagon;
                    if (wagonPeople == peopleWaiting)
                    {
                        NoPeople = true;
                        break;
                    }
                }

                peopleOnTheLift += peopleCurrentWagon;

                //if there is no more waiting people stop the program
                if (NoPeople)
                {
                    break;
                }
                peopleCurrentWagon = 0;
            }

            if (peopleWaiting > peopleOnTheLift)
            {  //if there are still people on the queue and no more available space,
                Console.WriteLine($"There isn't enough space! {peopleWaiting - peopleOnTheLift} people in a queue!");
                Console.WriteLine(string.Join(" ", wagon));
            }
            else if (peopleWaiting < wagon.Length * 4 && wagon.Any(w => w < 4))
            { //if there are no more people and the lift have empty spots 
                Console.WriteLine("The lift has empty spots!");
                Console.WriteLine(string.Join(" ", wagon));
            }
            else if (wagon.All(w => w == 4) && NoPeople)
            { //if the lift is full and there are no more people in the queue
                Console.WriteLine(string.Join(" ", wagon));
            }
        }
    }
}
