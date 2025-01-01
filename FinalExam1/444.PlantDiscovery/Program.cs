namespace _444.PlantDiscovery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); // Number of plants
            Dictionary<string, Plant> plants = new Dictionary<string, Plant>();

            // Reading the plants and their rarities
            for (int i = 0; i < n; i++)
            {
                string[] plantInfo = Console.ReadLine().Split("<->", StringSplitOptions.RemoveEmptyEntries);
                string plantName = plantInfo[0];
                int rarity = int.Parse(plantInfo[1]);

                if (!plants.ContainsKey(plantName))
                {
                    plants[plantName] = new Plant { Name = plantName, Rarity = rarity, Ratings = new List<int>() };
                }
                else
                {
                    plants[plantName].Rarity = rarity; // Update rarity if the plant already exists
                }
            }

            // Reading and processing commands
            string command;
            while ((command = Console.ReadLine()) != "Exhibition")
            {
                string[] commandParts = command.Split(": ", StringSplitOptions.RemoveEmptyEntries);
                string action = commandParts[0];
                string[] arguments = commandParts[1].Split(" - ", StringSplitOptions.RemoveEmptyEntries);

                string plantName = arguments[0];

                if (!plants.ContainsKey(plantName))
                {
                    Console.WriteLine("error");
                    continue;
                }

                switch (action)
                {
                    case "Rate":
                        int rating = int.Parse(arguments[1]);
                        plants[plantName].Ratings.Add(rating);
                        break;

                    case "Update":
                        int newRarity = int.Parse(arguments[1]);
                        plants[plantName].Rarity = newRarity;
                        break;

                    case "Reset":
                        plants[plantName].Ratings.Clear();
                        break;

                    default:
                        Console.WriteLine("error");
                        break;
                }
            }

            // Display the results
            Console.WriteLine("Plants for the exhibition:");
            foreach (Plant plant in plants.Values)
            {
                Console.WriteLine($"- {plant.Name}; Rarity: {plant.Rarity}; Rating: {plant.AverageRating:F2}");
            }
        }
    }
    class Plant
    {
        public string Name { get; set; }
        public int Rarity { get; set; }
        public List<int> Ratings { get; set; }

        public double AverageRating => Ratings.Any() ? Ratings.Average() : 0.0;
    }
}
