

/*
    • Its sum of digits is divisible by 8, e.g. 8, 17, 88
    • Holds at least one odd digit, e.g. 232, 707, 87578
    • Some examples of top numbers are: 17, 161, 251, 4310, 123200 

Create a program to print all top numbers in the range [1…n].


 */

using System;

namespace _10.TopNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int range = int.Parse(Console.ReadLine());
            for (int i = 1; i <= range; i++)
            {
                if (CheckSumDivisibleByEight(i)&& CheckHoldsOddDigit(i))
                {
                    Console.WriteLine(i);
                }
            }
        }
        static bool CheckSumDivisibleByEight(int number)
        {
            int sumOfDigits = 0;
            while (number > 0)
            {
                sumOfDigits += number % 10;
                number /= 10;
            }
            if (sumOfDigits%8==0)
            {
                return true;
            }
            return false;
        }
        static bool CheckHoldsOddDigit(int number)
        {
            while (number > 0)
            {
                int currentDigit=number % 10;
                if (currentDigit%2!=0)
                {
                    return true;
                }
                number /= 10;
            }
            return false;
        }
    }
}
