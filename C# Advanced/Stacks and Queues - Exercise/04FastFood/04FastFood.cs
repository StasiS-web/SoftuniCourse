using System;
using System.Collections.Generic;
using System.Linq;

namespace _04FastFood
{
    class FastFood
    {
        static void Main(string[] args)
        {
            int quantityFood = int.Parse(Console.ReadLine());
            int[] order = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray(); //quantity of an order
            Queue<int> orders = new Queue<int>(order); //all orders
            Console.WriteLine(orders.Max());  //biggest order

            for (int i = 0; i < order.Length; i++)
            {
                //check if there is enough food left to complete it
                if (quantityFood > 0)
                {
                    //it is not possible to complete all the orders
                    if (orders.Peek() > quantityFood)
                    {
                        break;
                    }

                    quantityFood -= orders.Dequeue();  //reduce the amount of food you have
                } 
            }

            //If you succeeded in servicing all of your clients
            if (orders.Count == 0)
            {
                Console.WriteLine("Orders complete");
            }
            else
            {
                //If there are orders left
                Console.WriteLine($"Orders left: {String.Join(' ', orders)}");
            }
        }
    }
}
