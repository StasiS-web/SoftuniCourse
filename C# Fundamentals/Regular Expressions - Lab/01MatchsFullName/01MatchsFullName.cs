using System;
using System.Text.RegularExpressions;

namespace _01MatchsFullNameLab
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\b([A-Z][a-z]+) ([A-Z][a-z]+)\b"; //get expression
            string fullName = Console.ReadLine();

            //match it with collection
            MatchCollection namesCollection = Regex.Matches(fullName, pattern);

            foreach (var name in namesCollection)
            {
                Console.Write(name + " ");
            }

            Console.WriteLine();
        }
    }
}
