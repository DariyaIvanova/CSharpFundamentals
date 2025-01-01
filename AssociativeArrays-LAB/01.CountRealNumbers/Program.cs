namespace _01.CountRealNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<double> numbers = Console.ReadLine().Split().Select(double.Parse).ToList();
            SortedDictionary<double, int> numbersCount = new SortedDictionary<double, int>();

            for (int i = 0; i < numbers.Count; i++)
            {
                if (!numbersCount.ContainsKey(numbers[i]))
                {
                    numbersCount.Add(numbers[i], 0);
                }
                numbersCount[numbers[i]]++;
                    
            }

            foreach (var item in numbersCount)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
               
            }
        }
    }
}
