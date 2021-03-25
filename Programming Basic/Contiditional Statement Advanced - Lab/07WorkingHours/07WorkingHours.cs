﻿using System;

namespace WorkingHours
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            String dayOfWeek = Console.ReadLine();

            switch (dayOfWeek)
            {
                case "Monday":
                case "Tuesday":
                case "Wednesday":
                case "Thursday":
                case "Friday":
                case "Saturday":
                    if (hours >= 10 && hours < 18)
                    {
                        Console.WriteLine("open");
                    }
                    else
                    {
                        Console.WriteLine("closed");
                    }
                    break;
                case "Sunday":
                    Console.WriteLine("closed");
                    break;
            }
        }
    }
}