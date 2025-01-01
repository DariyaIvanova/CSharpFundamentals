using System;

namespace _02.VowelsCount
{
    internal class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            Console.WriteLine(VowelsCount(input));
        }

       static int VowelsCount(string input)
        {
            int count = 0;
            for (int i = 0; i < input.Length; i++)
            {
                char ch = input[i];
                if (ch == 'a' || ch == 'o' || ch == 'e' || ch == 'u' || ch == 'i' || ch == 'A' || ch == 'O' || ch == 'E' || ch == 'U' || ch == 'I')
                {
                    count++;
                }
            }
            return count;
        }
    }
}
