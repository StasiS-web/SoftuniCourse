using WildFarm.Interfaces;

namespace WildFarm.Models.Animals.Mammals.Felines
{
    public abstract class Feline : Mammal, IFeline
    {
        protected Feline(string name, double weight, double weightModifier, string livingRegion, string breed) 
            : base(name, weight, weightModifier, livingRegion)
        {
            this.Breed = breed;
        }

        public string Breed {get; private set;}

        public override string ToString() => $"{this.GetType().Name} [{this.Name}, {this.Breed}, {this.Weight}, {this.LivingRegion}, {this.FoodEaten}]";
    }
}
