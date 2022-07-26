using System;
using WildFarm.Models.Foods;

namespace WildFarm.Models.Animals.Birds
{
    public class Owl : Bird
    {
        private const double modifier = 0.25;
        public Owl(string name, double weight, double wingSize) 
            : base(name, weight, modifier, wingSize)
        {
        }

        public override string ProduceSound() => "Hoot Hoot";

        public override void EatFood(Food food)
        {
            if (food is Meat)
            {
                Weight += food.Quantity * modifier;
                FoodEaten += food.Quantity;
            }
            else
            {
                Console.WriteLine($"{nameof(Owl)} does not eat {food.GetType().Name}!");
            }
        }
    }
}
