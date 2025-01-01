internal class Program
{
    static void Main()
    {
        double[] nums = Console.ReadLine().Split().Select(double.Parse).ToArray();

        for (int i = 0; i < nums.Length; i++)
        {
            int roundedNumber = (int)Math.Round(nums[i], MidpointRounding.AwayFromZero);
            Console.WriteLine($"{nums[i]} => {roundedNumber}");
        }
    }
}

