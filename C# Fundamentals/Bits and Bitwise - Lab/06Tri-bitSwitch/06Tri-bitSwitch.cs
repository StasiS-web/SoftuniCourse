using System;

namespace _06Tri_bitSwitch
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int index = int.Parse(Console.ReadLine());

            //shift left with 3 bits
            int mask = 7 << index;

            //invert the values of the three bits
            int result = number ^ mask;

            Console.WriteLine(result);
        }
    }
}
