using System;
using System.Collections.Generic;

namespace _06Supermarket
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> queueNames = new Queue<string>();

            string command = Console.ReadLine();

            while(command != "End")
            { 
                if (command == "Paid")
                {  //print every customer name and empty the queue
                    Console.WriteLine(string.Join(Environment.NewLine, queueNames));
                    queueNames.Clear();
                } 
                else
                { //adds the names in the queue
                    queueNames.Enqueue(command);
                }

                command = Console.ReadLine();
            }

            Console.WriteLine($"{queueNames.Count} people remaining.");
        }
    }
}
