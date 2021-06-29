namespace Restaurant
{
    public class Coffee : HotBeverage
    {
        private const decimal DefaultCoffeePrice = 3.5M;

        private const double DefaultCoffeeMilliliters = 50;

        public Coffee(string name, double caffeine)
            : base(name, DefaultCoffeePrice, DefaultCoffeeMilliliters)
        {
            Caffeine = caffeine;
        }

        public double Caffeine { get; set; }
    }
}
