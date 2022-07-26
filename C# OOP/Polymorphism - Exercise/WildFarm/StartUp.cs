using System;
using System.Collections.Generic;
using System.Text;
using WildFarm.Models.Animals;
using WildFarm.Models.Animals.Birds;
using WildFarm.Models.Animals.Mammals;
using WildFarm.Models.Animals.Mammals.Felines;
using WildFarm.Models.Foods;

namespace WildFarm
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<Animal> animals = new List<Animal>();
            Stack<Food> allFoods = new Stack<Food>();

            string input = Console.ReadLine();

            while (input != "End")
            {
                string[] tokens = input.Split();
                Animal animal = CreateAnimal(tokens);
                animals.Add(animal);

                tokens = Console.ReadLine().Split();
                Food food = CreateFoood(tokens, allFoods);

                Console.WriteLine(animal.ProduceSound());

                animal.EatFood(food);
                
                input = Console.ReadLine();
            }

            foreach(var animal in animals)
            {
                Console.WriteLine(animal);
            }
        }

        public static Animal CreateAnimal(string[] tokens)
        {
            Animal animal = null;

            switch(tokens[0])
            {
                case "Cat":
                    animal = new Cat(tokens[1], double.Parse(tokens[2]), tokens[3], tokens[4]);
                    break;

                case "Tiger":
                    animal = new Tiger(tokens[1], double.Parse(tokens[2]), tokens[3], tokens[4]);
                    break;

                case "Owl":
                case "Hen":
                    if (tokens[0] == nameof(Owl))
                    {
                        animal = new Owl(tokens[1], double.Parse(tokens[2]), double.Parse(tokens[3]));
                    }
                    else
                    {
                        animal = new Hen(tokens[1], double.Parse(tokens[2]), double.Parse(tokens[3]));
                    }
                    break;

                case "Mouse":
                    animal = new Mouse(tokens[1], double.Parse(tokens[2]), tokens[3]);
                    break;

                case "Dog":
                    animal = new Dog(tokens[1], double.Parse(tokens[2]), tokens[3]);
                    break;
            }

            return animal;
        }

        public static Food CreateFoood(string[] tokens, Stack<Food> foods)
        {
           int quantity = int.Parse(tokens[1]);

            if (tokens[0] == nameof(Vegetable))
            {
                foods.Push(new Vegetable(quantity));
            }
            else if (tokens[0] == nameof(Fruit))
            {
                foods.Push(new Fruit(quantity)); 
            }
            else if (tokens[0] == nameof(Meat))
            {
                foods.Push(new Meat(quantity));
            }
            else if (tokens[0] == nameof(Seeds))
            {
                foods.Push(new Seeds(quantity));
            }

            return foods.Pop();
        }
    }
}
