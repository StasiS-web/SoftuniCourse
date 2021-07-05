using System;

namespace Cars
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Seat seat = new Seat("Leon", "Grey");
            Tesla tesla = new Tesla("Model 3", "Red", 2);

            Console.WriteLine(seat);
            Console.WriteLine(tesla);
        }
    }
}
