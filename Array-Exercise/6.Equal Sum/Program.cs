using System;
using System.Runtime.InteropServices;

internal class Program
{
    static void Main()
    {
        string input = Console.ReadLine();
        if (input == "")
        {
            Console.WriteLine("no");return;
        }
        int[] numbers = input.Split().Select(int.Parse).ToArray();

        int leftsum = 0;
        int rightsum = 0;

        int maxValue = numbers.Max();
        int maxIndex = numbers.ToList().IndexOf(maxValue);
        if (numbers.Length == 1)
        { 
            Console.WriteLine("0"); return;
        }
        else
        {
            rightsum = numbers.Skip(maxIndex + 1).Sum();
            leftsum = numbers.Take(maxIndex).Sum();
            if (rightsum == leftsum)
            {
                Console.WriteLine(maxIndex);
            }
            else Console.WriteLine("no");
        }

        //int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        //if (nums.Length == 1)
        //{
        //    Console.WriteLine(0);
        //    return;
        //}

        //int leftSum = 0;
        //int rightSum = 0;

        //for (int i = 0; i < nums.Length; i++)
        //{
        //    leftSum = nums.Take(i).Sum();
        //    rightSum = nums.Skip(i + 1).Sum();
        //    if (leftSum == rightSum)
        //    {
        //        Console.WriteLine(i); return;
        //    }
        //}
        //Console.WriteLine("no");

    }
}

