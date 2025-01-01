using System.Text.RegularExpressions;

namespace _1.Furniture
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            List<Furniture> allFurnitures = new List<Furniture>();
            string pattern = @">>(?<Name>[A-Za-z]+)<<(?<Price>\d+|\d+\.\d+)!(?<Quantity>\d+)";

            string input = string.Empty;
            while ((input = Console.ReadLine()) != "Purchase")
            {
                foreach (Match match in Regex.Matches(input, pattern))
                {
                    Furniture newFurniture = new Furniture(
                        match.Groups["Name"].Value,
                        decimal.Parse(match.Groups["Price"].Value),
                        int.Parse(match.Groups["Quantity"].Value));
                    allFurnitures.Add(newFurniture);
                }
            }
            decimal total = 0;
            Console.WriteLine("Bought furniture:");
            foreach (var furniture in allFurnitures)
            {
                Console.WriteLine(furniture.Name);
                total += furniture.Price*furniture.Quantity;
            }
            Console.WriteLine($"Total money spend: {total:f2}");
        }
    }
    internal class Furniture
    {
        public string Name;
        public decimal Price;
        public int Quantity;

        public Furniture(string name, decimal price, int quantity)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
        }
    }
}
