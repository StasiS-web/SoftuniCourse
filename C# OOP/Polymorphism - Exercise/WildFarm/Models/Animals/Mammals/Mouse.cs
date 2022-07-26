using System;
using System.Collections.Generic;
using System.Text;
using WildFarm.Models.Foods;

namespace WildFarm.Models.Animals.Mammals
{
    public class Mouse : Mammal
    {
        private const double modifier = 0.10;
        public Mouse(string name, double weight, string livingRegion) 
            : base(name, weight, modifier, livingRegion)
        {
        }

        public override string ProduceSound() => "Squeak";

        public override void EatFood(Food food)
        {
            if (food is Vegetable || food is Fruit)
            {
                Weight += food.Quantity * modifier;
                FoodEaten += food.Quantity;
            }
            else
            {
                Console.WriteLine($"{nameof(Mouse)} does not eat {food.GetType().Name}!");
            }
        }

        public override string ToString() => $"{GetType().Name} [{this.Name}, {this.Weight}, {this.LivingRegion}, {this.FoodEaten}]";

    }
}
