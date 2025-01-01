using System;

namespace _03.LongerLine
{
    internal class Program
    {
        static void Main()
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            double x3 = double.Parse(Console.ReadLine());
            double y3 = double.Parse(Console.ReadLine());
            double x4 = double.Parse(Console.ReadLine());
            double y4 = double.Parse(Console.ReadLine());

            double topx1 = 0.0;
            double topy1 = 0.0;
            double topx2 = 0.0;
            double topy2 = 0.0;

            double firstLineLength = CalculateLineLength(x1, x2, y1, y2);
            double secondLineLength = CalculateLineLength(x3, x4, y3, y4);

            if (firstLineLength > secondLineLength)
            {
                topx1 = x1;
                topy1 = y1;
                topx2 = x2;
                topy2 = y2;
            }
            else
            {
                topx1 = x3;
                topy1 = y3;
                topx2 = x4;
                topy2 = y4;
            }

            CalculateClosestPointAndPrint(topx1, topy1, topx2, topy2);
        }
        static double CalculateLineLength(double x1, double x2, double y1, double y2)
        {
            double sideA = Math.Pow(Math.Abs(x2 - x1), 2);
            double sideB = Math.Pow(Math.Abs(y2 - y1), 2);
            double lineLength = Math.Sqrt(sideA + sideB);
            return lineLength;
        }

        static void CalculateClosestPointAndPrint(double x1, double y1, double x2, double y2)
        {

            double topX = 0;
            double topY = 0;
            double firstPointDistance = Math.Sqrt(Math.Pow(x1, 2) + Math.Pow(y1, 2));
            double secondPointDistance = Math.Sqrt(Math.Pow(x2, 2) + Math.Pow(y2, 2));
            if (firstPointDistance <= secondPointDistance)
            {
                topX = x1;
                topY = y1;
                Console.WriteLine($"({topX}, {topY})({x2}, {y2})");
            }
            else
            {
                topX = x2;
                topY = y2;
                Console.WriteLine($"({topX}, {topY})({x1}, {y1})");
            }
            
        }
    }
}
