using System;

namespace _05DigitsLettersAndOtherLab
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string digits = string.Empty;
            string letters = string.Empty;
            string others = string.Empty;

            //go through all the elements
            foreach (var item in input)
            {
                if (Char.IsDigit(item))
                {  //find digits 
                    digits += item;
                }
                else if (Char.IsLetter(item))
                { //find letters
                    letters += item;
                }
                else
                { //find other symbols 
                    others += item;
                }
            }

            Console.WriteLine(digits);
            Console.WriteLine(letters);
            Console.WriteLine(others);
        }
    }
}
