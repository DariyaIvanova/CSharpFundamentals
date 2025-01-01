using System.Text.RegularExpressions;

namespace _44.DestinationMapper
{
    internal class Program
    {
        static void Main(string[] args)
        {
           string initialInput=Console.ReadLine();

            string pattern = @"([=/])[A-Z][a-zA-Z]{2,}\1";

            MatchCollection matches=Regex.Matches(initialInput, pattern);

            List<string> destinations = new List<string>();

            foreach (Match match in matches)
            {
                string location = match.Value.Substring(1, match.Value.Length - 2);
                destinations.Add(location);
            }
            int travelPointsSum = 0;
            foreach (string destination in destinations)
            {
                travelPointsSum += destination.Length;
            }
            Console.WriteLine($"Destinations: {string.Join(", ", destinations)}");
            Console.WriteLine($"Travel Points: {travelPointsSum}");

        }
    }
}
