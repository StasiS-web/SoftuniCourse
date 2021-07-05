using System.Text;

namespace Cars
{
    public class Seat : Car, ICar
    {
        public Seat(string model, string color)
            :base(model, color)
        {
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{Color} Seat {Model}");
            sb.AppendLine(Start());
            sb.AppendLine(Stop());

            return sb.ToString().TrimEnd();
        }
    }
}
