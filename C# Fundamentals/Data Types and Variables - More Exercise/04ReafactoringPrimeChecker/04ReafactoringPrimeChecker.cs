using System;

namespace _04ReafactoringPrimeChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int prime = 2; prime <= n; prime++)
            {
                bool primeValue = true;

                for (int noPrime = 2; noPrime < prime; noPrime++)
                {
                    if (prime % noPrime == 0)
                    {
                        primeValue = false;
                        break;
                    }
                }

                Console.WriteLine("{0} -> {1}", prime, primeValue.ToString().ToLower());
            }
        }
    }
}
