using System;

namespace _01ReverseStringsLab
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            
            //get series of strin until you receive "end"
            while ((input = Console.ReadLine()) != "end")
            {
                string result = string.Empty;

                //reverse the string start from last index
                for (int i = input.Length - 1; i >= 0; i--)
                {  
                    result += input[i];
                }

                Console.WriteLine($"{input} = {result}");
            }
        }
    }
}
