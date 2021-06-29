using System;
using System.Linq;

namespace Animals
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string type;

            Animal animal;
            while ((type = Console.ReadLine()) != "Beast!")
            {
                string[] animalData = Console.ReadLine()
                    .Split(" ")
                    .ToArray();
                string name = animalData[0];
                int age = int.Parse(animalData[1]);
                string gender = animalData[2];

                if (type == "Cat")
                {
                    try
                    {
                        animal = new Cat(name, age, gender);
                        Console.WriteLine(animal.ToString());
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
                else if (type == "Dog")
                {
                    try
                    {
                        animal = new Dog(name, age, gender);
                        Console.WriteLine(animal.ToString());
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
                else if (type == "Frog")
                {
                    try
                    {
                        animal = new Frog(name, age, gender);
                        Console.WriteLine(animal.ToString());
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
                else if (type == "Tomcat")
                {
                    try
                    {
                        animal = new Tomcat(name, age);
                        Console.WriteLine(animal.ToString());
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
                else if (type == "Kitten")
                {
                    try
                    {
                        animal = new Kitten(name, age);
                        Console.WriteLine(animal.ToString());
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
            }
        }
    }
}
