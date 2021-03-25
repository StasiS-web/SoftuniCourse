using System;

namespace OldBooks
{
    class Program
    {
        static void Main(string[] args)
        {
            //read the book names
            
            string targetBook = Console.ReadLine();

            //counter for books
            int countBooks = 0;
            bool isBookFound = false;

            
            //read until receive "No More Books"
            while (true)
            {
                string nextBook = Console.ReadLine();

                //if command == searchBook print that you find it and counter for books
                if (nextBook == targetBook)
                {
                    isBookFound = true;
                    break;
                }
                else if (nextBook == "No More Books")
                {
                    break;
                }
                    countBooks++; //counting the amounrt of books
            }
            //if command is different from "No More Books" then you didn't found it
            if (isBookFound)
            {
                Console.WriteLine($"You checked {countBooks} books and found it.");
            }
            else
            {
                Console.WriteLine("The book you search is not here!");
                Console.WriteLine($"You checked {countBooks} books."); //print amount of checked books
            }
        }
    }
}
