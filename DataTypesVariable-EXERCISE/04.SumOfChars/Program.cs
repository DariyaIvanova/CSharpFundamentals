using System;

namespace _04.SumOfChars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int linesCount = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = 0; i < linesCount; i++)
            {
                char currentLetter=char.Parse(Console.ReadLine());
                sum += (int)currentLetter;
            }
            Console.WriteLine($"The sum equals: {sum}");

        }
    }
}
