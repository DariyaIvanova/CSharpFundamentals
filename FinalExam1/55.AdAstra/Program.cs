using System.Text.RegularExpressions;

namespace _55.AdAstra
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern= @"([#|])([A-Za-z\s]+)\1(\d{2}/\d{2}/\d{2})\1(\d{1,4}|10000)\1";

            MatchCollection matches=Regex.Matches(input, pattern);
            List<Items> allItems=new List<Items>();
            int totalCalories = 0;

            foreach (Match match in matches)
            {
                string itemName = match.Groups[2].Value;
                string expirationDate = match.Groups[3].Value;
                int calories = int.Parse(match.Groups[4].Value);
                allItems.Add(new Items {ItemName= itemName,ExpirationDate= expirationDate, Calories= calories});

                totalCalories += calories;
            }
            int daysOfFood = totalCalories / 2000;
            Console.WriteLine($"You have food to last you for: {daysOfFood} days!");
            foreach (Items item in allItems)
            {
                Console.WriteLine($"Item: {item.ItemName}, Best before: {item.ExpirationDate}, Nutrition: {item.Calories}");
            }
        }
        class Items
        {
            public string ItemName { get; set; }
            public string ExpirationDate { get; set; }
            public int Calories { get; set; }
        }
    }
}
