namespace _03.Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            double avarageNumber = numbers.Sum() / numbers.Count;
            List<int> greaterThanAvarage = numbers.Where(x => x > avarageNumber).ToList();
            if (greaterThanAvarage.Count==0)
            {
                Console.WriteLine("No");
                return;
            }

            greaterThanAvarage = greaterThanAvarage.OrderByDescending(x=>x).ToList();
            int length = greaterThanAvarage.Count;

            if (length > 5)
            {
                greaterThanAvarage.RemoveRange(5, length - 5);
            }

            Console.WriteLine(string.Join(" ", greaterThanAvarage));

        }
    }
}
