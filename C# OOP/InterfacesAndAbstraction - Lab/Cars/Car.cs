namespace Cars
{
    public abstract class Car : ICar
    {
        public Car(string model, string color)
        {
            Model = model;
            Color = color;
        }

        public string Model { get; private set; }

        public string Color { get; private set; } 

        public virtual string Start() => "Engine start";

        public virtual string Stop() => "Breaaak!";
    }
}
