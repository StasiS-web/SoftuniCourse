using System;

namespace CustomRandomList
{
    public class StartUp
    {
        static void Main()
        {
            RandomList list2 = new RandomList();
            Console.WriteLine(list2.RandomString());

            RandomList list = new RandomList();
            list.Add("Maxi");
            list.Add("Rex");
            list.Add("Roxy");
            list.Add("Mishi");

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(list.RandomString());
            }
        }
    }
}
