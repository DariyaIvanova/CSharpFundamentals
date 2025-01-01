internal class Program
{
    static void Main()
    {
        int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();


        int sumEven = nums.Where(x => x % 2 == 0).ToArray().Sum();
        int sumOdd = nums.Where(x => x % 2 != 0).ToArray().Sum();
        int difference=sumEven - sumOdd;
        Console.WriteLine(difference);

    }
}

