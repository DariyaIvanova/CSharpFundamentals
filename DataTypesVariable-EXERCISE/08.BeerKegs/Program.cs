using System;

namespace _08.BeerKegs
{
    internal class Program
    {
        static void Main()
        {
            int countKegs = int.Parse(Console.ReadLine());
            string bestModel = "";
            double bestVolume = 0.0;

            for (int i = 0; i < countKegs; i++)
            {
                string modelKeg = Console.ReadLine();
                double radius=double.Parse(Console.ReadLine());
                int heigth=int.Parse(Console.ReadLine());

                double currentVolume = Math.PI * Math.Pow(radius, 2) * heigth;
                if (currentVolume>bestVolume)
                {
                    bestVolume = currentVolume;
                    bestModel= modelKeg;
                }

            }
            Console.WriteLine(bestModel);
        }
    }
}
