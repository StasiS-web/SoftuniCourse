using System;

namespace _05Messages
{
    class Program
    {
        static void Main(string[] args)
        {
            int index = int.Parse(Console.ReadLine());
            string message = string.Empty;

            for (int i = 0; i < index; i++)
            {
                string input = Console.ReadLine();

                int digitsLength = input.Length;
                int digit = input[0] - '0';
                int offset = (digit - 2) * 3;

                if (digit == 0)
                {
                    message += (char)(digit + 32);
                    continue;
                }

                if (digit == 8 || digit == 9)
                {
                    offset++;
                }
                int letterIndex = offset + digitsLength - 1;
                message += (char)(letterIndex + 97);
            }

            /*for (int i = 0; i < index; i++)
            {
                string input = Console.ReadLine();

                int digitsLength = int.Parse(Console.ReadLine());
                char digits = Convert.ToChar(input);

                if (digits == '2')
                {
                    if (digitsLength == 1)
                    { 
                        message += 'a';
                    }
                    else if (digitsLength == 2)
                    {
                        message += 'b';
                    }
                    else if (digitsLength == 3)
                    {
                        message += 'c';
                    }
                }
                else if (digits == '3')
                {
                    if (digitsLength == 1)
                    {
                        message += 'd';
                    }
                    else if (digitsLength == 2)
                    {
                        message += 'e';
                    }
                    else if (digitsLength == 3)
                    {
                        message += 'f';
                    }
                }
                else if (digits == '4')
                {
                    if (digitsLength == 1)
                    {
                        message += 'g';
                    }
                    else if (digitsLength == 2)
                    {
                        message += 'h';
                    }
                    else if (digitsLength == 3)
                    {
                        message += 'i';
                    }
                }
                else if (digitsLength == '5')
                {
                    if (digitsLength == 1)
                    {
                        message += 'j';
                    }
                    else if (digitsLength == 2)
                    {
                        message += 'k';
                    }
                    else if (digitsLength == 3)
                    {
                        message += 'l';
                    }
                }
                else if (digitsLength == '6')
                {
                    if (digitsLength == 1)
                    {
                        message += 'm';
                    }
                    else if (digitsLength == 2)
                    {
                        message += 'n';
                    }
                    else if (digitsLength == 3)
                    {
                        message += 'o';
                    }
                }
                else if (digitsLength == '7')
                {
                    if (digitsLength == 1)
                    {
                        message += 'p';
                    }
                    else if (digitsLength == 2)
                    {
                        message += 'q';
                    }
                    else if (digitsLength == 3)
                    {
                        message += 'r';
                    }
                    else if (digitsLength == 4)
                    {
                        message += 's';
                    }
                }
                else if (digitsLength == '8')
                {
                    if (digitsLength == 1)
                    {
                        message += 't';
                    }
                    else if (digitsLength == 2)
                    {
                        message += 'u';
                    }
                    else if (digitsLength == 3)
                    {
                        message += 'v';
                    }
                }
                else if (digitsLength == '9')
                {
                    if (digitsLength == 1)
                    {
                        message += 'w';
                    }
                    else if (digitsLength == 2)
                    {
                        message += 'x';
                    }
                    else if (digitsLength == 3)
                    {
                        message += 'y';
                    }
                    else if (digitsLength == 4)
                    {
                        message += 'z';
                    }
                }
                else if (digitsLength == '0')
                {
                    message += " ";
                }
            }*/

            Console.WriteLine(message);
        }
    }
}
