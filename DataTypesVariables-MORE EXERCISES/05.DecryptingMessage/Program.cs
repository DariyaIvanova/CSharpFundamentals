using System;

namespace _05.DecryptingMessage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int key = int.Parse(Console.ReadLine());
            int count = int.Parse(Console.ReadLine());

            char[] encreptedMessage = new char[count];

            for (int i = 0; i < encreptedMessage.Length; i++)
            {
                char currentChar = char.Parse(Console.ReadLine());
                int currentCharNum = (int)currentChar;

                encreptedMessage[i] = (char)(currentCharNum+key);
            }
            Console.WriteLine(string.Join("", encreptedMessage));
        }
    }
}
