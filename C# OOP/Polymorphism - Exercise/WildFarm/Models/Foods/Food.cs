using WildFarm.Interfaces;

namespace WildFarm.Models.Foods
{
    public abstract class Food : IFood
    {
        public Food(int quantity)
        {
            this.Name = $"{this.GetType().Name}";
            this.Quantity = quantity;
        }

        public string Name { get; set; }

        public int Quantity { get; set; }
    }
}
