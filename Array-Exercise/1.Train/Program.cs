internal class Program
{
    static void Main()
    {
        int count = int.Parse(Console.ReadLine());
        int[] arr=new int[count];
        for (int i = 0; i < count; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine(string.Join(" ", arr));
        Console.WriteLine(arr.Sum());
    }
}

