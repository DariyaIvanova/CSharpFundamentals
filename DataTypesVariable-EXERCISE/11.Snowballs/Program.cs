﻿using System;
using System.Numerics;

namespace _11.Snowballs
{
    internal class Program
    {
        static void Main()
        {

            int count = int.Parse(Console.ReadLine());
            int bestSnowballSnow = 0;
            int bestSnowballTime = 0;
            int bestSnowballQuality = 0;
            BigInteger bestSnowballValue = 0;


            for (int i = 0; i < count; i++)
            {
                int snowballSnow = int.Parse(Console.ReadLine());
                int snowballTime = int.Parse(Console.ReadLine());
                int snowballQuality = int.Parse(Console.ReadLine());

                BigInteger snowballValue = BigInteger.Pow((snowballSnow / snowballTime), snowballQuality);

                if (snowballValue> bestSnowballValue)
                {
                    bestSnowballValue = snowballValue;
                    bestSnowballSnow=snowballSnow;
                    bestSnowballTime=snowballTime;
                    bestSnowballQuality=snowballQuality;
                }
            }
            Console.WriteLine($"{bestSnowballSnow} : {bestSnowballTime} = {bestSnowballValue} ({bestSnowballQuality})");





        }
    }
}
