using System;

internal class Program
{
    static void Main(string[] args)
    {
        int count = int.Parse(Console.ReadLine());
        int[] numArr = new int[count];

        for (int i = 0; i < count; i++)
        {
            numArr[i] = int.Parse(Console.ReadLine());
        }
        //algorithm for reversing an array

        for (int i = 0; i < numArr.Length / 2; i++)
        {
            int temp = numArr[i];
            numArr[i] = numArr[numArr.Length - i - 1];
            numArr[numArr.Length - i - 1] = temp;
        }
        Console.WriteLine(string.Join(" ", numArr));

    }
}

