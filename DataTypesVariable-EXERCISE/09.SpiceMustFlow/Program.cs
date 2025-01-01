using System;

namespace _09.SpiceMustFlow
{
    internal class Program
    {
        static void Main()

        {
            int yield = int.Parse(Console.ReadLine());
            int extratedSpices = 0;
            int days = 0;

            const int minYield = 100;
            const int workersConsume = 26;
            const int yieldDrop = 10;

            while (yield >= minYield)
            {
                days++;
                extratedSpices += yield - workersConsume;
                yield -= yieldDrop;
             
            }

            extratedSpices -= workersConsume;
            if (extratedSpices<0)
            {
                extratedSpices = 0;
            }
            Console.WriteLine(days);
            Console.WriteLine(extratedSpices);

        }

    }
}
