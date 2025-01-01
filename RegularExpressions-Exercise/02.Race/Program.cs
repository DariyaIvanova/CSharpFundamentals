using System.Text;
using System.Text.RegularExpressions;

namespace _02.Race
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> participentsMap = new Dictionary<string, int>();

            string[] participentsArray = Console.ReadLine().Split(", ");
            for (int i = 0; i < participentsArray.Length; i++)
            {
                participentsMap.Add(participentsArray[i], 0);
            }
            string input = string.Empty;
            string digitsPatters = @"\d";
            string letterPattern = @"[A-Za-z]";

            while ((input = Console.ReadLine()) != "end of race")
            {
                StringBuilder foundName = new StringBuilder();
                foreach (Match match in Regex.Matches(input, letterPattern))
                {
                    foundName.Append(match.Value);
                }

                if (participentsMap.ContainsKey(foundName.ToString()))
                {
                    int distance = 0;
                    foreach (Match match in Regex.Matches(input, digitsPatters))
                    {
                        distance += int.Parse(match.Value);
                    }
                    participentsMap[foundName.ToString()] += distance;
                }
            }
            string winnerName = GetWinnerName(participentsMap);
            Console.WriteLine($"1st place: {winnerName}");
            participentsMap.Remove(winnerName);

            winnerName = GetWinnerName(participentsMap);
            Console.WriteLine($"2nd place: {winnerName}");
            participentsMap.Remove(winnerName);

            winnerName = GetWinnerName(participentsMap);
            Console.WriteLine($"3rd place: {winnerName}");
            participentsMap.Remove(winnerName);




        }

        private static string GetWinnerName(Dictionary<string, int> participentsMap)
        {
            string winnerName = "";
            int maxKm = 0;
            foreach (var pair in participentsMap)
            {
                if (pair.Value>maxKm)
                {
                    maxKm = pair.Value;
                    winnerName = pair.Key;
                }
            }
            return winnerName;


        }
    }
}
