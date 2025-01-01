using System.Globalization;

internal class Program
{
    static void Main()
    {
        string input;
        decimal balance = 0;


        while ((input = Console.ReadLine()) != "Start")
        {
            double currentCoin = double.Parse(input);
            if (currentCoin == 0.1 || currentCoin == 0.2 || currentCoin == 0.5 || currentCoin == 1 || currentCoin == 2)
            {
                balance += (decimal)currentCoin;
            }
            else
            {
                Console.WriteLine($"Cannot accept {currentCoin}");
            }
        }

        while ((input = Console.ReadLine()) != "End")
        {
            switch (input)
            {
                case "Nuts":
                    if (balance >= 2)
                    {
                        balance -= 2;
                        Console.WriteLine($"Purchased nuts");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                    break;
                case "Water":
                    if (balance >= 0.7m)
                    {
                        balance -= 0.7m;
                        Console.WriteLine($"Purchased water");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                    break;
                case "Crisps":
                    if (balance >= 1.5m)
                    {
                        balance -= 1.5m;
                        Console.WriteLine($"Purchased crisps");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                    break;

                case "Soda":
                    if (balance >= 0.8m)
                    {
                        balance -= 0.8m;
                        Console.WriteLine($"Purchased soda");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                    break;

                case "Coke":
                    if (balance >= 1.0m)
                    {
                        balance -= 1.0m;
                        Console.WriteLine($"Purchased coke");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                    break;

                    default:
                    Console.WriteLine("Invalid product");
                    break;
            }

        }
        Console.WriteLine($"Change: {balance:f2}");
    }
    
}

