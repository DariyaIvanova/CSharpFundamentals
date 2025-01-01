using System;

internal class Program
{
    static void Main()
    {
        int[] arr1 = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int[] arr2 = Console.ReadLine().Split().Select(int.Parse).ToArray();
        bool equal = true;

        for (int i = 0; i < arr1.Length; i++)
        {
            if (arr1[i] != arr2[i])
            {
                Console.WriteLine($"Arrays are not identical. Found difference at {i} index");
                equal = false;
                break;
            }
        }
        if (equal) 
        {
            int sum = arr1.Sum();
                Console.WriteLine($"Arrays are identical. Sum: {sum}"); 
        }

    }
}

