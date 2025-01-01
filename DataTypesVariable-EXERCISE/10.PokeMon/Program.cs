using System;

namespace _10.PokeMon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pokemonPower = int.Parse(Console.ReadLine());
            int distanceBetweenTargets = int.Parse(Console.ReadLine());
            int exhaustionFactor = int.Parse(Console.ReadLine());

            double halfPower = pokemonPower / 2.0;


            int targetsCount = 0;

            while (pokemonPower>= distanceBetweenTargets)
            {
                pokemonPower = pokemonPower - distanceBetweenTargets;
                targetsCount++;
                if (pokemonPower==halfPower&& exhaustionFactor!=0)
                {
                    pokemonPower = pokemonPower / exhaustionFactor;
                }
            }
            Console.WriteLine(pokemonPower);
            Console.WriteLine(targetsCount);
        }
    }
}
