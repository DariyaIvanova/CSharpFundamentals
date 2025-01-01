using System;

namespace _07.RepeatString
{
    internal class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            int count=int.Parse(Console.ReadLine());
            Console.WriteLine(RepeatedString(input, count));

        }
        static string RepeatedString(string input, int count)
        {
            string[] repeatedNewString= new string[input.Length];
            for (int i = 0; i < count; i++)
            {
                repeatedNewString[i] = input;
            }
            return string.Join("", repeatedNewString);
        }
    }
}
