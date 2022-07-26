using WildFarm.Models.Foods;

namespace WildFarm.Interfaces
{
    public interface IAnimal
    {
        public string Name { get; }
        public double Weight { get; }
        public int FoodEaten { get; }
        string ProduceSound();
        void EatFood(Food food);
    }
}
