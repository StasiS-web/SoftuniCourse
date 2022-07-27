using System;

namespace SquareRoot
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            try
            {
                int num = int.Parse(Console.ReadLine());

                if (num < 0)
                {
                    throw new ArgumentException("Invalid number.");
                }

                double a = Math.Sqrt(num);

                Console.WriteLine(a);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Goodbye.");
            }
        }
    }
}
