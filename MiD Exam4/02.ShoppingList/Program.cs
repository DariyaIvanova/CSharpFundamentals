



namespace _02.ShoppingList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> groceries = Console.ReadLine().Split("!").ToList();

            string input = string.Empty;

            while ((input=Console.ReadLine())!="Go Shopping!")
            {
                string[] commands = input.Split().ToArray();
                string command=commands[0];
                string item = commands[1];


                switch (command)
                {
                    case "Urgent":
                        groceries = UrgentGrocery(groceries, item);
                        break;

                    case "Unnecessary":
                        groceries = UnnecessaryGrocery(groceries, item);
                        break;

                    case "Correct":
                        string newItem = commands[2];
                        groceries = CorrectGrocery(groceries, item, newItem);
                        break;

                    case "Rearrange":
                        groceries = RearangeGrocery(groceries, item);
                        break;

                }
            }
            Console.WriteLine(string.Join(", ", groceries));
        }

        static List<string> RearangeGrocery(List<string> groceries, string item)
        {
            if (groceries.Contains(item))
            {
                groceries.Remove(item);
                groceries.Add(item);
                
            }
            return groceries;
        }

        static List<string> CorrectGrocery(List<string> groceries, string item, string newItem)
        {
            if (groceries.Contains(item))
            {
                int index=groceries.IndexOf(item);
                groceries[index]=newItem;
            }
            return groceries;
        }

        static List<string> UnnecessaryGrocery(List<string> groceries, string item)
        {
            if (groceries.Contains(item))
            {
                groceries.Remove(item);
            }
            return groceries;
        }

        static List<string> UrgentGrocery(List<string> groceries, string item)
        {
            if (!groceries.Contains(item))
            {
                groceries.Insert(0, item);
            }
            return groceries;
        }
    }
}
