using System;

namespace _08.MathPower
{
    internal class Program
    {
        static void Main()
        {
            double number = double.Parse(Console.ReadLine());
            double power = double.Parse(Console.ReadLine());
            Console.WriteLine(MathPower(number, power));
        }
        static double MathPower(double number, double power )
        {
            double result =1.0;
            for (int i = 0; i < power; i++)
            {
                result = result * number;
            }
            return result;
        }
    }
}
