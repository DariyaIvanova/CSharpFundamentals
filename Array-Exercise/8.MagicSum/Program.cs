internal class Program
{
    static void Main()
    {
        int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int number = int.Parse(Console.ReadLine());
        for (int i = 0; i < nums.Length-1; i++)
        {
            for (int j = i+1; j <= nums.Length-1; j++)
            {
                if (nums[i] + nums[j] ==number)
                {
                    Console.WriteLine($"{nums[i]} {nums[j]}");
                }
            }
        }

    }
}

