namespace _03.WordSynonyms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, List <string>>  wordSysnonym=new Dictionary<string, List<string>>();


            for (int i = 0; i < n; i++)
            {
                string word=Console.ReadLine();
                string synonym = Console.ReadLine();

                if (!wordSysnonym.ContainsKey(word))
                {
                    wordSysnonym.Add(word, new List<string>());
                }
                wordSysnonym[word].Add(synonym);
            }

            foreach (var item in wordSysnonym)
            {
                Console.WriteLine($"{item.Key} - {string.Join(", ", item.Value)}");
            }
        }
    }
}
