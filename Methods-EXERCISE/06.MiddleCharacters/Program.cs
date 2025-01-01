using System;

namespace _06.MiddleCharacters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            MiddleCharactersPrint(input);

        }

        static void MiddleCharactersPrint(string input)
        {
            int indexPrnt = input.Length / 2;

            if (input.Length % 2 != 0)
            {
                Console.WriteLine($"{input[indexPrnt]}");
            }
            else
            {
                Console.WriteLine($"{input[indexPrnt - 1]}{input[indexPrnt]}");
            }
        }
    }
}
