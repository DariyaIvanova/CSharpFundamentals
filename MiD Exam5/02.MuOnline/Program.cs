using System.Linq;
using System.Threading;

namespace _02.MuOnline
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> rooms = Console.ReadLine()
                .Split("|")
                .ToList();

            int initialHealth = 100;
            int bitcoins = 0;
            for (int i = 0; i < rooms.Count; i++)
            {
                string[] commands = rooms[i].Split().ToArray();
                string command = commands[0];
                int number = int.Parse(commands[1]);

                switch (command)
                {
                    case "potion":
                        int healed = 0;
                        if (initialHealth + number >= 100)
                        {

                            healed = 100 - initialHealth;
                            initialHealth = 100;
                        }
                        else
                        {
                            initialHealth += number;
                            healed = number;
                        }
                        Console.WriteLine($"You healed for {healed} hp.");
                        Console.WriteLine($"Current health: {initialHealth} hp.");
                        break;

                    case "chest":
                        bitcoins += number;
                        Console.WriteLine($"You found {number} bitcoins.");
                        break;
                    default:
                        initialHealth -= number;
                        if (initialHealth <= 0)
                        {
                            Console.WriteLine($"You died! Killed by {command}.");
                            Console.WriteLine($"Best room: {i + 1}");
                            return;
                        }
                        Console.WriteLine($"You slayed {command}.");
                        break;
                }
               
            }
            Console.WriteLine($"You've made it!\r\nBitcoins: {bitcoins}\r\nHealth: {initialHealth}");
        }

    }
}
