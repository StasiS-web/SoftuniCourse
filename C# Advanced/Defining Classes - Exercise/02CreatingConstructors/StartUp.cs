using System;

namespace DefiningClasses
{
    public class StartUp
    {
        public static void Main()
        {
            //-------------------Problem Solution 01------------------
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
            Console.WriteLine("-------------------------------------------");

            //-------------------Problem Solution 02------------------
            Person leo = new Person(24);
            Console.WriteLine($"{leo.Name} - {leo.Age}");

            Person noName = new Person();
            Console.WriteLine($"{noName.Name} - {noName.Age}");

            Person ana = new Person("Ana", 24);
            Console.WriteLine($"{ana.Name} - {ana.Age}");
        }
    }
}
