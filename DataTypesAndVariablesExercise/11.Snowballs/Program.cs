using System.Numerics;

internal class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int bestSnow = 0, bestTime = 0, bestQuality = 0;
        BigInteger bestSnowBallValue = 0;

        for (int i = 0; i < n; i++)
        {
            int snowBallSnow = int.Parse(Console.ReadLine());
            int snowBallTime = int.Parse(Console.ReadLine());
            int snowBallQuality = int.Parse(Console.ReadLine());

            BigInteger snowBallValue = BigInteger.Pow((snowBallSnow / snowBallTime),snowBallQuality);

            if (snowBallValue>bestSnowBallValue)
            {
                bestSnowBallValue=snowBallValue;
                bestSnow = snowBallSnow;
                bestTime = snowBallTime;
                bestQuality = snowBallQuality;

            }
        }
        Console.WriteLine($"{bestSnow} : {bestTime} = {bestSnowBallValue} ({bestQuality})");
    }
}

