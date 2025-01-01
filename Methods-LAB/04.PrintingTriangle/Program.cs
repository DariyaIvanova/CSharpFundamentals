using System;
using System.Runtime.InteropServices;

namespace _04.PrintingTriangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            PrintUpperPart(count);
            PrintLowerPart(count);


        }

        static void PrintUpperPart(int count)
        {
            for (int i = 1; i <=count ; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write($"{j} ");
                }
                Console.WriteLine();
            }

        }

        static void PrintLowerPart(int count)
        {
            for (int i = 1; i <= count-1; i++)
            {
                for (int j = 1; j <=count-i ; j++)
                {
                    Console.Write($"{j} ");
                }
                Console.WriteLine();
            }
        }
    }
}
