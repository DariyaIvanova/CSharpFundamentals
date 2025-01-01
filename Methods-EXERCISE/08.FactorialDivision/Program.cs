using System;
using System.Numerics;

namespace _08.FactorialDivision
{
    internal class Program
    {
        static void Main()
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            double firstFactorial=FactorialCalculation(num1);
            double secondFactorial = FactorialCalculation(num2);
            if (num2!=0)
            {
                double result = firstFactorial / secondFactorial*1.0;
                Console.WriteLine($"{result:f2}");
            }
            
        }

        static double FactorialCalculation(int num)
        {
            double factorial = 1;
            for (int i = num; i >= 2; i--)
            {
                factorial *= i;
            }
            if (num == 0)
            {
                return 0;
            }
            return factorial;
        }
    }
}
