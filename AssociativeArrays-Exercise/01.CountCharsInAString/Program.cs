namespace _01.CountCharsInAString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary <char, int> charOcurrencies = new Dictionary<char, int>();

            for (int i = 0; i < input.Length; i++)
            {
                var character= input[i];
                if (character == ' ')
                {
                    continue;
                }
                if (!charOcurrencies.ContainsKey(character))
                {
                    charOcurrencies.Add(character, 0);
                }
                charOcurrencies[character]++;
            }
            foreach (var currentChar in charOcurrencies)
            {
                Console.WriteLine($"{currentChar.Key} -> {currentChar.Value}");
            }
        }
    }
}
