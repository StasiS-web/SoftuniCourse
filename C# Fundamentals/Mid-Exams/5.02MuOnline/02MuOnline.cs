using System;
using System.Linq;

namespace _02MuOnline
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] rooms = Console.ReadLine()
                     .Split('|')
                     .ToArray();
            
            //intitilise initial health and coins
            int health = 100;
            int bitcoins = 0;

            int bestRoom = 0;
            bool madeIt = true;

            for (int i = 0; i < rooms.Length; i++)
            {
                string[] token = rooms[i].Split(" ");
                string command = token[0];
                int number = int.Parse(token[1]);
                bestRoom++;

                if (command == "potion")
                {  //healling potions recove your health
                    int currHealth = health;
                    health += number;

                    if (health > 100)
                    {
                        health = 100;
                        int amounth = 100 - currHealth;
                        Console.WriteLine($"You healed for {amounth} hp.");
                    }
                    else 
                    {
                        Console.WriteLine($"You healed for {number} hp.");
                    }

                    Console.WriteLine($"Current health: {health} hp.");
                }
                else if (command == "chest")
                { //found a chest with coins
                    bitcoins += number;
                    Console.WriteLine($"You found {number} bitcoins.");
                }
                else 
                { //met a monster
                    health -= number;

                    if (health > 0)
                    {
                        Console.WriteLine($"You slayed {command}.");
                    }
                    else
                    {  //you've been killed
                        Console.WriteLine($"You died! Killed by {command}.");
                        Console.WriteLine($"Best room: {bestRoom}");
                        madeIt = false;
                        break;
                    }
                }
            }

            //if you passed through all the rooms
            if (madeIt)
            {
                Console.WriteLine("You've made it!");
                Console.WriteLine($"Bitcoins: {bitcoins}");
                Console.WriteLine($"Health: {health}");
            }
        }
    }
}
