

/*
 1 2 3 4 5 6 7 8
 */
internal class Program
{
    static void Main()
    {
        int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();

        int k = nums.Length / 4;

        int[] top = new int[nums.Length / 2];
        int[] bottom = new int[nums.Length / 2];
        int[] sum = new int[nums.Length / 2];

        int leftIndex = k - 1;
        for (int i = 0; i < k; i++)
        {
            top[i] = nums[leftIndex];
            leftIndex--;
        }

        int rightIndex = nums.Length-1;

        for (int j = k; j < nums.Length / 2; j++)
        {
            top[j] = nums[rightIndex];
            rightIndex--;
        }

        int bottomIndex = k;
        for (int l = 0; l < nums.Length / 2; l++)
        {
            bottom[l] = nums[bottomIndex];
            bottomIndex++;
        }

        for (int s = 0; s < nums.Length / 2; s++)
        {
            sum[s] = top[s] + bottom[s];
        }

        Console.WriteLine(string.Join(" ", sum));
    }
}

