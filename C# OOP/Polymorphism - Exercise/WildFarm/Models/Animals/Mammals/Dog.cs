using System;
using WildFarm.Models.Foods;

namespace WildFarm.Models.Animals.Mammals
{
    public class Dog : Mammal
    {
        private const double modifier = 0.40;
        public Dog(string name, double weight, string livingRegion) 
            : base(name, weight, modifier, livingRegion)
        {
        }

        public override string ProduceSound() => "Woof!";

        public override void EatFood(Food food)
        {
            if(food is Meat)
            {
                Weight += food.Quantity * modifier;
                FoodEaten += food.Quantity;
            }
            else
            {
                Console.WriteLine($"{nameof(Dog)} does not eat {food.GetType().Name}!");
            }
        }

        public override string ToString() => $"{GetType().Name} [{this.Name}, {this.Weight}, {this.LivingRegion}, {this.FoodEaten}]";
    }
}
