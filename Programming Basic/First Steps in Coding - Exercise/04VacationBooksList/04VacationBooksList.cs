﻿using System;

namespace VacationBooksList
{
    class Program
    {
        static void Main(string[] args)
        {
            int pages = int.Parse(Console.ReadLine());
            double pagesPerHour = double.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());

            double totalTimeForBook = pages / pagesPerHour;
            double neededHours = totalTimeForBook / days;

            Console.WriteLine(neededHours);
           
        }
    }
}
