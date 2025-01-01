namespace _02.TreasureHunt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> initialLoot = Console.ReadLine().Split("|").ToList();

            string input = string.Empty;

            while ((input = Console.ReadLine()) != "Yohoho!")
            {

                string[] commands = input.Split().ToArray();
                string command = commands[0];
                switch (command)
                {
                    case "Loot":
                        List<string> itemsToBeAdded = new List<string>();
                        for (int i = 1; i < commands.Length; i++)
                        {
                            if (!initialLoot.Contains(commands[i]))
                            {
                                itemsToBeAdded.Add(commands[i]);
                            }
                        }
                        itemsToBeAdded.Reverse();
                        initialLoot.InsertRange(0, itemsToBeAdded);
                        break;
                    case "Drop":
                        int index = int.Parse(commands[1]);
                        if (CheckIndexRange(initialLoot, index))
                        {
                            string itemToBeRemoved = initialLoot[index];
                            initialLoot.RemoveAt(index);
                            initialLoot.Add(itemToBeRemoved);
                        }
                        break;
                    case "Steal":
                        int count = int.Parse(commands[1]);
                        if (count < initialLoot.Count)
                        {
                            List<string> removedItems = new List<string>();
                            for (int i = 0; i < initialLoot.Count; i++)
                            {
                                if (i >= initialLoot.Count - count)
                                {
                                    removedItems.Add(initialLoot[i]);
                                }
                            }
                            initialLoot.RemoveRange(initialLoot.Count - count, count);
                            Console.WriteLine(string.Join(", ", removedItems));
                        }
                        else
                        {
                            Console.WriteLine(string.Join(", ", initialLoot));
                            initialLoot.RemoveRange(0, initialLoot.Count);                           
                        }
                        break;
                }
            }

            if (initialLoot.Count == 0)
            {
                Console.WriteLine($"Failed treasure hunt.");
            }
            else
            {
                double averageGain = 0.0;
                foreach (string item in initialLoot)
                {
                    averageGain += item.Length;
                }
                averageGain /= initialLoot.Count;
                Console.WriteLine($"Average treasure gain: {averageGain:f2} pirate credits.");
            }
        }

        static bool CheckIndexRange(List<string> initialLoot, int index)
        {
            if (index < 0 || index > initialLoot.Count - 1)
            {
                return false;
            }
            return true;
        }
    }
}
