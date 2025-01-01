using System;

namespace _01.SmallestOfThreeNumbers
{
    internal class Program
    {
        static void Main()
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());

            Console.WriteLine(MaxNumber(num1, num2, num3));
        }
        static int MaxNumber(int first, int second, int third)
        {
            int minNumber = int.MaxValue;
            if (first< minNumber)
            {
                minNumber = first;
            }
            if (second < minNumber)
            {
                minNumber = second;
            }
            if (third < minNumber)
            {
                minNumber = third;
            }
            return minNumber;
        }
    }
}
