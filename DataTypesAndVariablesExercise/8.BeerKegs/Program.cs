﻿internal class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        double biggestKegVolume = 0;
        string biggestKegName = "";


        for (int i = 0; i < n; i++)
        {
            string model = Console.ReadLine();
            double radius=double.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());

            double currentKegVolume = Math.PI * Math.Pow(radius, 2) * height;

            if (currentKegVolume>biggestKegVolume)
            {
                biggestKegVolume=currentKegVolume;
                biggestKegName = model;
            }
        }
        Console.WriteLine(biggestKegName);
    }
}
