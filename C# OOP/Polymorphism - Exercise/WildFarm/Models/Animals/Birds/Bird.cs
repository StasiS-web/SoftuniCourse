using WildFarm.Interfaces;

namespace WildFarm.Models.Animals.Birds
{
    public abstract class Bird : Animal, IBird
    {
        public Bird(string name, double weight, double weightModifier, double wingSize) 
            : base(name, weight, weightModifier)
        {
            this.WingSize = wingSize;
        }

        public double WingSize { get; set; }

        public override string ToString() => $"{GetType().Name} [{this.Name}, {this.WingSize}, {this.Weight}, {this.FoodEaten}]";
    }
}
