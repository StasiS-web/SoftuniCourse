using System;
using System.Threading.Channels;

namespace SumOfIntegers
{
    internal class StartUp
    {
        static void Main(string[] args)
        {
            var sum = 0;
            var elements = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries);

            foreach (var elem in elements)
            {
                try
                {
                    var output = int.Parse(elem);
                    sum += output;
                }
                catch (OverflowException)
                {
                    Console.WriteLine($"The element '{elem}' is out of range!");
                }
                catch (FormatException)
                {
                    Console.WriteLine($"The element '{elem}' is in wrong format!");
                }
                finally
                {
                    Console.WriteLine($"Element '{elem}' processed - current sum: {sum}");
                }
            }

            Console.WriteLine($"The total sum of all integers is: {sum}");
        }
    }
}
