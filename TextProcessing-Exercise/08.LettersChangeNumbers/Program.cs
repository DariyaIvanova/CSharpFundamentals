using System;

namespace _08.LettersChangeNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] strings = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            decimal totalSum = 0;


            foreach (string str in strings)
            {
                char letterBefore = str[0];
                char LetterAfter = str[str.Length - 1];
                ulong currentNumber = ulong.Parse(str.Substring(1, str.Length - 2));

                ulong position;
                decimal result = 0;

                if (char.IsUpper(letterBefore))
                {
                    position = (ulong)(letterBefore - 'A' + 1);
                    result = currentNumber / (decimal)position;
                }
                else if (char.IsLower(letterBefore))
                {
                    position = (ulong)(letterBefore - 'a' + 1);
                    result = currentNumber * position;
                }

                if (char.IsUpper(LetterAfter))
                {
                    position = (ulong)(LetterAfter - 'A' + 1);
                    result -= position;
                }
                else if (char.IsLower(LetterAfter))
                {
                    position = (ulong)(LetterAfter - 'a' + 1);
                    result += position;

                   
                }
                totalSum += result;


            }
            Console.WriteLine($"{totalSum:F2}");
        }
    }
}
