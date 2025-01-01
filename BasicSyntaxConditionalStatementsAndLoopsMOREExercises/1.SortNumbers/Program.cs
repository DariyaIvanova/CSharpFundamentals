internal class Program
{
    static void Main()
    {
        int[] nums = new int[3];

        for (int i = 0; i < nums.Length; i++)
        {
            nums[i] = int.Parse(Console.ReadLine());
        }

        Array.Sort(nums, (a, b) => b.CompareTo(a));
        for (int i = 0; i < nums.Length; i++)
        {
            Console.WriteLine(nums[i]);
        }

    }
}

