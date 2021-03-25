using System;

namespace _03SubstringLab
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine().ToLower();
            string text = Console.ReadLine();

            //until text conatin word
            while (text.Contains(word))
            {   //get index
                int index = text.IndexOf(word.ToLower());

                if (index == -1)
                {
                    break;
                }

                //remove word from text
                text = text.ToLower().Remove(index, word.Length);
            }

            Console.WriteLine(text);
        }
    }
}
