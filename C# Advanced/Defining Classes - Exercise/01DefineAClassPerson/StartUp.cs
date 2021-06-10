using System;

namespace DefiningClasses
{
    public class StartUp
    {
        public static void Main()
        {
            Person firstPerson = new Person()
            {
                Name = "Pesho",
                Age = 20
            };

            Person secondPerson = new Person()
            {
                Name = "Gosho",
                Age = 18
            };

            Person thirdPerson = new Person()
            {
                Name = "Stamat",
                Age = 43
            };

            Console.WriteLine($"{firstPerson.Name} - {firstPerson.Age}");
            Console.WriteLine($"{secondPerson.Name} - {secondPerson.Age}");
            Console.WriteLine($"{thirdPerson.Name} - {thirdPerson.Age}");
        }
    }
}
