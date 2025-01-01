namespace _02.OddOccurrences
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> sequenceWord = Console.ReadLine().Split().ToList();

            Dictionary <string, int> counts = new Dictionary<string, int>();

            for (int i = 0; i < sequenceWord.Count; i++)
            {
                string word= sequenceWord[i].ToLower();
                if (!counts.ContainsKey(word))
                {
                    counts.Add(word, 0);
                }
                counts[word]++;
            }
            foreach (KeyValuePair<string, int> item in counts)
            {
                if (item.Value%2==1)
                {
                    Console.Write($"{item.Key} ");
                }
            }
            Console.WriteLine();
        }
    }
}
