using System;

namespace _10.MultiplyEvensByOdds
{
    internal class Program
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            number = Math.Abs(number);
            int result= GetEvenDigitsSum(number)*GetOddDigitsSum(number);
            Console.WriteLine(result);

        }

        static int GetEvenDigitsSum(int number)
        {
            int sum = 0;
            while (number>0)
            {
                int currentNum = number % 10;
                if (currentNum % 2 == 0) { sum += currentNum; }
                number /= 10;
            }
            return sum;
        }
        static int GetOddDigitsSum(int number)
        {
            int sum = 0;
            while (number > 0)
            {
                int currentNum = number % 10;
                if (currentNum % 2 != 0) { sum += currentNum; }
                number /= 10;
            }
            return sum;
        }
    }
}
