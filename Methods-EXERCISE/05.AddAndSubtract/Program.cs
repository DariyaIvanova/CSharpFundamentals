using System;

namespace _05.AddAndSubtract
{
    internal class Program
    {
        static void Main()
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());

            int result = Subtract(SumNumbers(num1, num2), num3);
            Console.WriteLine(result);

        }
        static int SumNumbers(int first, int second)
        {
            return first + second;
        }
        static int Subtract(int summedNums, int third)
        {
            
            return summedNums - third;
        }
    }
}
