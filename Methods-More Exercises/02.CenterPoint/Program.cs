using System;

namespace _02.CenterPoint
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            CalculateClosestPoint(x1, y1, x2, y2);
        }
        static void CalculateClosestPoint(double x1, double y1, double x2, double y2)
        {

            double topX = 0;
            double topY = 0;
            double firstPointDistance = Math.Sqrt(Math.Pow(x1, 2) + Math.Pow(y1, 2));
            double secondPointDistance = Math.Sqrt(Math.Pow(x2, 2) + Math.Pow(y2, 2));
            if (firstPointDistance <= secondPointDistance)
            {
                topX = x1;
                topY = y1;
            }
            else
            {
                topX = x2;
                topY = y2;
            }
            Console.WriteLine($"({topX}, {topY})");
        }
    }
}
