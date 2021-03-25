using System;

namespace _02BitAtPositionOne
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            int mask = 1 << 1; //after shift left with 1

            //after shift right take last value
            int result = (number & mask) >> 1;

            Console.WriteLine(result);
        }
    }
}
