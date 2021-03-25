using System;
using System.Text.RegularExpressions;

namespace _03MatchDatesLab
{
    class Program
    {
        static void Main(string[] args)
        {
            string dates = Console.ReadLine();
            string pattern = @"\b(\d{2})([.\/-])([A-Z][a-z]{2})\2(\d{4})\b";  //get expression

            //receive a match
            MatchCollection dateCollection = Regex.Matches(dates, pattern);

            foreach (Match date in dateCollection)
            { //match group values by its key
                var day = date.Groups[1].Value;
                var mounth = date.Groups[3].Value;
                var year = date.Groups[4].Value;

               Console.WriteLine($"Day: {day}, Month: {mounth}, Year: {year}");
            }
        }
    }
}
