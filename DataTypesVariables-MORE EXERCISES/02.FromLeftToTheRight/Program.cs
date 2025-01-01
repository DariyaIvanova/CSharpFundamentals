using System;
using System.Linq;
using System.Numerics;

namespace _02.FromLeftToTheRight
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int count=int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                string input=Console.ReadLine();
                BigInteger[] nums=input.Split(" ").Select(BigInteger.Parse).ToArray();
                if (nums[0] > nums[1])
                {
                    Console.WriteLine(SumDigits(nums[0]));
                }
                else
                {
                    Console.WriteLine(SumDigits(nums[1]));
                }

            }
        }
        static BigInteger SumDigits(BigInteger number)
        {
            BigInteger sum = 0;
            if (number<0)
            {
                number *= -1;
            }
            while (number>0)
            {
                int currentDigit = (int)(number % 10);
                sum += currentDigit;
                number = number / 10;
            }
            return sum;
        }
    }
}
