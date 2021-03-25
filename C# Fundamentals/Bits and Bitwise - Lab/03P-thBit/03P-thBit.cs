using System;

namespace _03P_thBit
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int index = int.Parse(Console.ReadLine());

            int mask = 1 << index; //after shift left with position value

            int result = (number & mask) >> index; //after shift right with position value

            Console.WriteLine(result);
        }
    }
}
