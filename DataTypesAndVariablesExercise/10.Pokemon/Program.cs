internal class Program
{
    static void Main()
    {
        int nPower = int.Parse(Console.ReadLine()); //power
        int n = nPower;
        double halfPower = nPower * 50 / 100;
        int m = int.Parse(Console.ReadLine()); //distancePokeTargets
        int y = int.Parse(Console.ReadLine()); // exhaustionFactor

        int pokesCount = 0;
        while (n>=m)
        {
            n = n - m;
            pokesCount++;
            if ((double)n == halfPower)
            {
                if (n / y != 0)
                {
                    n = n / y;
                }
                else
                {
                    n = n - m;
                }
            }
        }
        Console.WriteLine(n);
        Console.WriteLine(pokesCount);
    }
}

