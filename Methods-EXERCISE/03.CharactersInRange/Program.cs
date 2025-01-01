using System;
using System.IO;

namespace _03.CharactersInRange
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char firstCh = char.Parse(Console.ReadLine());
            char secondCh = char.Parse(Console.ReadLine());
            CharactersInRange(firstCh, secondCh);
        }

        static void CharactersInRange(char firstCh, char secondCh)
        {
            char temp;
            if (firstCh > secondCh)
            {
                temp = firstCh;
                firstCh = secondCh;
                secondCh = temp;
            }
            for (int i = firstCh + 1; i <= secondCh - 1; i++)
            {
                Console.Write($"{(char)i} ");
            }
        }
    }
}
