﻿internal class Program
{
    static void Main(string[] args)
    {
        int num = int.Parse(Console.ReadLine());
        PrintSign(num);
    }
    static void PrintSign(int number)
    {
        if (number<0)
        {
            Console.WriteLine($"The number {number} is negative.");
        }
        else if (number>0)
        {
            Console.WriteLine($"The number {number} is positive.");
        }
        else
            Console.WriteLine($"The number {number} is zero.");
    }
}

