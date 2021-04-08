using System;

namespace _03GamingStore
{
    class Program
    {
        static void Main(string[] args)
        {
            //read balance
            double balance = double.Parse(Console.ReadLine());
            string game = Console.ReadLine();
            
            double totalExpences = 0;

            //until you get  “Game Time” , you have to keep buying games.
            while (game != "Game Time")
            {
                double price = 0; // declare the price of the game
                //insert the price for each game
                switch (game) 
                {
                    case "OutFall 4":
                        price = 39.99;
                        break;
                    case "CS: OG":
                        price = 15.99;
                        break;
                    case "Zplinter Zell":
                        price = 19.99;
                        break;
                    case "Honored 2":
                        price = 59.99;
                        break;
                    case "RoverWatch":
                        price = 29.99;
                        break;
                    case "RoverWatch Origins Edition":
                        price = 39.99;
                        break;
                    default:
                    Console.WriteLine("Not Found");
                       game = Console.ReadLine();
                        continue;
                }

                //check if the price of the item is enough to buy or is more than 0
                if (balance >= price && balance > 0)
                {
                    Console.WriteLine($"Bought {game}");
                    totalExpences += price;
                    balance -= price;
                }
                else 
                {
                    Console.WriteLine("Too Expensive");
                    game = Console.ReadLine();
                    continue;
                }
                
                //check if the balance is 0
                if (balance == 0)
                {
                    Console.WriteLine("Out of money!");
                    break;
                }

                game = Console.ReadLine();
            }

                Console.WriteLine($"Total spent: ${totalExpences:f2}. Remaining: ${(balance):f2}");
        }
    }
}
