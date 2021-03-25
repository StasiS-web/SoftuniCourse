using System;

namespace _04BitDestryer
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int index = int.Parse(Console.ReadLine());

            //afther shift left and invert the mask
            int mask = ~(1 << index);

            //set the value of a number to 0
            int newNumber = number & mask;

            Console.WriteLine(newNumber);
        }
    }
}
