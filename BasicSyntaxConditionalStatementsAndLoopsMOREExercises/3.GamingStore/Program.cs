internal class Program
{
    static void Main()
    {
        decimal currentBalance = decimal.Parse(Console.ReadLine());
        decimal totalSpent = 0;

        string input = "";

        while ((input=Console.ReadLine())!= "Game Time")
        {
            switch (input)
            {
                case "OutFall 4":
                    
                    if (currentBalance > 39.99m) 
                    {
                        currentBalance -= 39.99m; 
                        totalSpent += 39.99m;
                        Console.WriteLine($"Bought {input}"); 
                    }
                    else if (currentBalance < 39.99m) { Console.WriteLine("Too Expensive"); }
                    else if (currentBalance == 39.99m) { Console.WriteLine("Out of money!"); return; }
                    break;
                case "CS: OG":
                    
                    if (currentBalance > 15.99m) 
                    {
                        currentBalance -= 15.99m; 
                        totalSpent += 15.99m;
                        Console.WriteLine($"Bought {input}"); 
                    }
                    else if (currentBalance < 15.99m) { Console.WriteLine("Too Expensive"); }
                    else if (currentBalance == 15.99m) { Console.WriteLine("Out of money!"); return; }
                    
                    break;
                case "Zplinter Zell":
                    
                    if (currentBalance > 19.99m) 
                    {
                        currentBalance -= 19.99m; 
                        totalSpent += 19.99m;
                        Console.WriteLine($"Bought {input}"); 
                    }
                    else if (currentBalance < 19.99m) { Console.WriteLine("Too Expensive"); }
                    else if (currentBalance == 19.99m) { Console.WriteLine("Out of money!"); return; }
                    
                    break;
                case "Honored 2":
                    
                    if (currentBalance > 59.99m) 
                    {
                        currentBalance -= 59.99m; 
                        totalSpent += 59.99m;
                        Console.WriteLine($"Bought {input}"); 
                    }
                    else if (currentBalance < 59.99m) { Console.WriteLine("Too Expensive"); }
                    else if (currentBalance == 59.99m) { Console.WriteLine("Out of money!"); return; }
                    
                    break;

                case "RoverWatch":
                    
                    if (currentBalance > 29.99m) 
                    {
                        currentBalance -= 29.99m; totalSpent += 29.99m;
                        Console.WriteLine($"Bought {input}"); 
                    }
                    else if (currentBalance < 29.99m) { Console.WriteLine("Too Expensive"); }
                    else if (currentBalance == 29.99m) { Console.WriteLine("Out of money!"); return; }
                    
                    break;
                case "RoverWatch Origins Edition":
                    
                    if (currentBalance > 39.99m) 
                    {
                        currentBalance -= 39.99m; totalSpent += 39.99m;
                        Console.WriteLine($"Bought {input}"); 
                    }
                    else if (currentBalance < 39.99m) { Console.WriteLine("Too Expensive"); }
                    else if (currentBalance == 39.99m) { Console.WriteLine("Out of money!"); return; }
                    
                    break;

                default:
                    Console.WriteLine("Not Found");
                    break;
            }
        }
        Console.WriteLine($"Total spent: ${totalSpent:f2}. Remaining: ${currentBalance:f2}");
    }
}

