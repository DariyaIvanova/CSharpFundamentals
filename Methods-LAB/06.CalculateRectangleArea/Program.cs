using System;

namespace _06.CalculateRectangleArea
{
    internal class Program
    {
        static void Main()
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            Console.WriteLine($"{GetRectangleArea(width, height)}");

        }
        static double GetRectangleArea(double width, double heigth)
        {
            double area = width * heigth;
            return area;
        }
    }
}
