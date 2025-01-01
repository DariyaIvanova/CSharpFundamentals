using System;

namespace _07.NxNMatrix
{
    internal class Program
    {
        static void Main()
        {
            int num = int.Parse(Console.ReadLine());
            NxNMatrixPrint(num);
        }

        static void NxNMatrixPrint(int num)
        {
            for (int i = num - 1; i >= 0; i--)
            {
                for (int j = 0; j < num; j++)
                {
                    Console.Write($"{num} ");
                }
                Console.WriteLine();
            }
        }
    }
}
