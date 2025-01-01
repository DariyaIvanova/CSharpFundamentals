using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string input = Console.ReadLine();

        // Regex to match valid emojis
        string emojiPattern = @"(\:\:|\*\*)([A-Z][a-z]{2,})\1";
        Regex emojiRegex = new Regex(emojiPattern);

        // Regex to match digits
        string digitPattern = @"\d";
        Regex digitRegex = new Regex(digitPattern);

        // Calculate cool threshold
        long coolThreshold = 1;
        foreach (Match match in digitRegex.Matches(input))
        {
            coolThreshold *= int.Parse(match.Value);
        }

        Console.WriteLine($"Cool threshold: {coolThreshold}");

        // Find all emojis and calculate their coolness
        MatchCollection emojiMatches = emojiRegex.Matches(input);
        List<string> coolEmojis = new List<string>();

        foreach (Match match in emojiMatches)
        {
            string emoji = match.Value;
            string emojiContent = match.Groups[2].Value;

            int coolness = 0;
            foreach (char ch in emojiContent)
            {
                coolness += (int)ch;
            }

            if (coolness >= coolThreshold)
            {
                coolEmojis.Add(emoji);
            }
        }

        // Output results
        Console.WriteLine($"{emojiMatches.Count} emojis found in the text. The cool ones are:");
        foreach (string coolEmoji in coolEmojis)
        {
            Console.WriteLine(coolEmoji);
        }
    }
}
