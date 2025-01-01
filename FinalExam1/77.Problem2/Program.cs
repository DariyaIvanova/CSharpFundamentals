using System.Text.RegularExpressions;

namespace _77.Problem2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            
            string patternToBeMatch = @"\|(?<boss>[A-Z]{4,})\|:#(?<title>[A-Za-z]+\s[A-Za-z]+)#";

            for (int i = 0; i < count; i++)
            {
                string input = Console.ReadLine();
                Match match = Regex.Match(input, patternToBeMatch);

                if (match.Success)
                {
                    string bossName = match.Groups["boss"].Value;
                    int strength = bossName.Length;
                    string title = match.Groups["title"].Value;
                    int armor = title.Length;

                    Console.WriteLine($"{bossName}, The {title}");
                    Console.WriteLine($">> Strength: {strength}");
                    Console.WriteLine($">> Armor: {armor}");
                }
                else
                {
                    Console.WriteLine("Access denied!");
                }
            }
        }
    }
}
