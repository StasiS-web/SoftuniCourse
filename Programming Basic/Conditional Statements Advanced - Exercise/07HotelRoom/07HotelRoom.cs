using System;

namespace HotelRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int countNights = int.Parse(Console.ReadLine());

            double studioPrice = 0;
            double apartmentPrice = 0;

            double totalStudioPrice = 0;
            double totalApartmentPrice = 0;

            if (month == "May" || month == "October")
            {
                if (countNights > 7 && countNights <= 14)
                {
                    studioPrice = 50 * countNights;
                    totalStudioPrice = 0.95 * studioPrice;
                }
                else if (countNights > 14)
                {
                    studioPrice = 50 * countNights;
                    totalStudioPrice = 0.70 * studioPrice;
                }
                else
                {
                    totalStudioPrice = 50 * countNights;
                }
                if (countNights > 14)
                {
                    apartmentPrice = 65 * countNights;
                    totalApartmentPrice = 0.90 * apartmentPrice;
                }
                else
                {
                    totalApartmentPrice = 65 * countNights;
                }
            }
            else if (month == "June" || month == "September")
            {
                if (countNights > 14)
                {
                    studioPrice = 75.20 * countNights;
                    totalStudioPrice = 0.80 * studioPrice;
                }
                else
                {
                    totalStudioPrice = 75.20 * countNights;
                }
                if (countNights > 14)
                {
                    apartmentPrice = 68.70 * countNights;
                    totalApartmentPrice = 0.90 * apartmentPrice;
                }
                else
                {
                    totalApartmentPrice = 68.70 * countNights;
                }
            }
            else if (month == "July" || month == "August")
            {
                totalStudioPrice = 76 * countNights;

                if (countNights > 14)
                {
                    apartmentPrice = 77 * countNights;
                    totalApartmentPrice = 0.90 * apartmentPrice;
                }
                else
                {
                    totalApartmentPrice = 77 * countNights;
                }
            } 
                
                Console.WriteLine($"Apartment: {totalApartmentPrice:f2} lv.");
                Console.WriteLine($"Studio: {totalStudioPrice:f2} lv.");
        }
    }
}
