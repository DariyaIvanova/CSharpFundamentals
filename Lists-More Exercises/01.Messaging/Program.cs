using System;
using System.Collections.Generic;
using System.Linq;
/*
 9992 562 8933 = >29 13 23

abcde  5

This is some message for you 
 
 */
namespace _01.Messaging
{
    
    
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();
            string text = Console.ReadLine();
            List<char> convertedString = ConvertStringToList(text);
            List<char> resultText = new List<char>();

            foreach (int number in nums)
            {
                int currentNum = number;
                int sumOfDigits = CalculateSumOfDigitsInNumber(number);
                int index=sumOfDigits;
                if (sumOfDigits > convertedString.Count)
                {
                    index=sumOfDigits%text.Length;
                }
                resultText.Add(convertedString[index]);
                convertedString.RemoveAt(index);

            }
            Console.WriteLine(string.Join("", resultText));
        }

        static List<char> ConvertStringToList(string str)
        {
            List<char> convertedString = new List<char>();

            for (int i = 0; i < str.Length; i++)
            {
                convertedString.Add(str[i]);
            }
            return convertedString;
        }
        static int CalculateSumOfDigitsInNumber(int number)
        {
            int sum = 0;
            while (number>0)
            {
                sum += number % 10;
                number /= 10;
            }

            return sum;
        }
    }
}
