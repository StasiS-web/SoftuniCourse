using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02MatchPhoneNumberLab
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"(\+359 2 (\d{3} \d{4}\b))|(\+359-2-(\d{3}-\d{4}\b))"; //get pattern
            string phones = Console.ReadLine();

            //match pattern with collection
            MatchCollection phoneNumbers = Regex.Matches(phones, pattern);

            //turn them into array
            var phoneCollections = phoneNumbers
                .Cast<Match>()
                .Select(a => a.Value.Trim())
                .ToArray();

            Console.WriteLine(string.Join(", ", phoneCollections));
        }
    }
}
