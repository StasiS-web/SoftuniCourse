using System;
using System.Collections;

namespace _01ReverseStringsSolution2
{
    class ReverseStringsSolution2
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            input = Reverse(input);
            Console.Write(input);
        }

        public static String Reverse(String input)
        {
            char[] chars = input.ToCharArray();
            int size = chars.Length;
            Stack stack = new Stack(size);

            for (int i = 0; i < size; i++)
            {
                stack.Push(chars[i]);
            }

            for (int i = 0; i < size; i++)
            {
                chars[i] = (char)stack.Pop();
            }

            return String.Join("", chars);
        }
    }
}
