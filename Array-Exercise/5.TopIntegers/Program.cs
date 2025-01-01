internal class Program
{
    static void Main()
    {
        int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();

        for (int i = 0; i < array.Length-1; i++)
        {
            if (array[i] > array[i + 1])
            {
                Console.Write($"{array[i]} ");
            }
        }
        Console.Write($"{array[array.Length-1]}");
    }
}

