﻿internal class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        for (int i = 1; i <=10; i++)
        {
            int result = n * i;
            Console.WriteLine($"{n} X {i} = {result}");
            result = 1;
        }
    }
}

