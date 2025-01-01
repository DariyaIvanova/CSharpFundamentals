internal class Program
{
    static void Main()
    {

        int[] arr = Console.ReadLine()
        .Split()
        .Select(int.Parse)
        .ToArray();

        int rotations = int.Parse(Console.ReadLine());

        rotations = rotations % arr.Length;

        for (int i = 0; i < rotations; i++)
        {
            int firstElement = arr[0];
            for (int j = 0; j < arr.Length - 1; j++)
            {
                arr[j] = arr[j + 1];
            }
            arr[arr.Length - 1] = firstElement;
        }
        Console.WriteLine(string.Join(" ", arr));
    }
}

