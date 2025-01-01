
namespace _03.Inventory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> inventory = Console.ReadLine().Split(", ").ToList();
            string input = string.Empty;

            while ((input = Console.ReadLine()) != "Craft!")
            {
                string[] commands = input.Split(" - ").ToArray();
                string command = commands[0];
                string item = commands[1];

                switch (command)
                {
                    case "Collect":
                        if (!CheckItemExistance(inventory, item))
                        {
                            inventory.Add(item);
                        }
                        break;
                    case "Drop":
                        if (CheckItemExistance(inventory, item))
                        {
                            inventory.Remove(item);
                        }
                        break;
                    case "Combine Items":
                        string[] oldNewItems = item.Split(":").ToArray();
                        string oldItem = oldNewItems[0];
                        string newItem = oldNewItems[1];
                        if (CheckItemExistance(inventory, oldItem))
                        {
                            int indexOfOldItem = inventory.IndexOf(oldItem);
                            inventory.Insert(indexOfOldItem + 1, newItem);
                        }

                        break;
                    case "Renew":
                        if (CheckItemExistance(inventory, item))
                        {
                            int indexOfItem = inventory.IndexOf(item);
                            inventory.RemoveAt(indexOfItem);
                            inventory.Add(item);
                        }
                        break;


                }

            }
            Console.WriteLine(string.Join(", ", inventory));
        }

        static bool CheckItemExistance(List<string> inventory, string item)
        {
            if (inventory.Contains(item))
            {
                return true;
            }
            return false;
        }
    }
}
