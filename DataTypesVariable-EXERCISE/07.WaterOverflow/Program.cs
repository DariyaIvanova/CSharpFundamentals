using System;

namespace _07.WaterOverflow
{
    internal class Program
    {
        static void Main()
        {
            int count = int.Parse(Console.ReadLine());
            int capacity = 255;
            int tankFullness = 0;


            for (int i = 0; i < count; i++)
            {
                int waterQuantity=int.Parse(Console.ReadLine());
                if ((capacity - waterQuantity) < 0)
                {
                    Console.WriteLine("Insufficient capacity!");continue;
                }
                else
                {
                    capacity -= waterQuantity;
                    tankFullness += waterQuantity;
                }
            }
            Console.WriteLine(tankFullness);
        }
    }
}
