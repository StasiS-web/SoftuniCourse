using System.Text;

namespace Cars
{
    public class Tesla : Car, IElectricCar
    {
        public Tesla(string model, string color, int battery)
            : base(model, color)
        {
            Battery = battery;
        }

        public int Battery { get ; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{Color} Tesla {Model} with {Battery} Batteries");
            sb.AppendLine(Start());
            sb.AppendLine(Stop());

            return sb.ToString().TrimEnd();
        }
    }
}
