namespace _66.BakeryShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input=string.Empty;
            Dictionary<string, int> bakeryShop= new Dictionary<string, int>();
            int sumSoldGoods = 0;
            while ((input=Console.ReadLine())!="Complete")
            {
                string[] commands=input.Split(" ").ToArray();

                string command=commands[0];
                int quantity = int.Parse(commands[1]);
                string food = commands[2];

                if (command=="Receive")
                {
                    if (quantity<=0)
                    {
                        continue;
                    }
                    if (!bakeryShop.ContainsKey(food))
                    {
                        bakeryShop[food] = 0;
                    }
                    bakeryShop[food] += quantity;
                }
                else if (command=="Sell")
                {
                    if (!bakeryShop.ContainsKey(food))
                    {
                        Console.WriteLine($"You do not have any {food}.");
                        continue;
                    }
                    if (bakeryShop[food]<quantity)
                    {
                        Console.WriteLine($"There aren't enough {food}. You sold the last {bakeryShop[food]} of them.");
                        sumSoldGoods += bakeryShop[food];
                        bakeryShop.Remove(food);
                    }
                    else
                    {
                        Console.WriteLine($"You sold {quantity} {food}.");
                        sumSoldGoods += quantity;
                        bakeryShop[food]-=quantity;
                        if (bakeryShop[food]==0)
                        {
                            bakeryShop.Remove(food);
                        }
                    }
                }
            }

            foreach (KeyValuePair<string, int> item in bakeryShop)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
            Console.WriteLine($"All sold: {sumSoldGoods} goods");
        }
    }
}
