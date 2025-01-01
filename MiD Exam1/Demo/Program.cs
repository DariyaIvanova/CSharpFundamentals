namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> nums = Console.ReadLine().Split().ToList();

            List<int> indexes = Console.ReadLine().Split().Select(int.Parse).ToList();
            

            indexes = indexes.OrderDescending().ToList();
            for (int i = 0; i < indexes.Count; i++)
            {
                nums.RemoveAt(indexes[i]);
            }
            Console.WriteLine(string.Join(" ", nums));
        }
    }
}
