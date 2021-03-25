using System;

namespace Sequence2KPlus1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            int a = 1;
            while (a <= num)
            {
                Console.WriteLine(a);
                a = a * 2 + 1;
            }
        }
    }
}
