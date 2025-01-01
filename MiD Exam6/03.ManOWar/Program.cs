namespace _03.ManOWar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> pirateShip = Console.ReadLine().Split(">").Select(int.Parse).ToList();
            List<int> warShip = Console.ReadLine().Split(">").Select(int.Parse).ToList();
            int maxHealth = int.Parse(Console.ReadLine());
            string input = string.Empty;

            while ((input = Console.ReadLine()) != "Retire")
            {
                List<string> commands = input.Split().ToList();
                string command = commands[0];

                switch (command)
                {
                    case "Fire":
                        int index = int.Parse(commands[1]);
                        int damage = int.Parse(commands[2]);
                        Fire(warShip, index, damage);
                        break;

                    case "Defend":
                        int startIndex = int.Parse(commands[1]);
                        int endIndex = int.Parse(commands[2]);
                        int damageFromWarship = int.Parse(commands[3]);
                        Defend(pirateShip, startIndex, endIndex, damageFromWarship);
                        break;

                    case "Repair":
                        int indexRepair = int.Parse(commands[1]);
                        int health = int.Parse(commands[2]);
                        Repair(pirateShip, maxHealth, indexRepair, health);
                        break;
                    case "Status":

                        Status(pirateShip, maxHealth);

                        break;
                }
            }
            int pirateShipSum = pirateShip.Sum();
            int warShipSum = warShip.Sum();

            bool pirateShipBreakage = pirateShip.Where(x => x <= 0).ToList().Count > 0;
            bool warShipBreakage = warShip.Where(x => x <= 0).ToList().Count > 0;

            if (!pirateShipBreakage && !warShipBreakage)
            {
                Console.WriteLine($"Pirate ship status: {pirateShipSum}");
                Console.WriteLine($"Warship status: {warShipSum}");
            }


        }
        static void Status(List<int> pirateShip, int maxHealth)
        {
            int countSectionToBeRepaired = 0;

            for (int i = 0; i < pirateShip.Count; i++)
            {
                int currentSectionValue = pirateShip[i];
                double percentSection = (double)currentSectionValue * 1.0 / maxHealth * 100;

                if (percentSection < 20.0)
                {
                    countSectionToBeRepaired++;
                }
            }
            Console.WriteLine($"{countSectionToBeRepaired} sections need repair.");
        }
        static void Repair(List<int> pirateShip, int maxHealth, int indexRepair, int health)
        {
            if (CheckIndexBoundery(pirateShip, indexRepair))
            {

                if ((pirateShip[indexRepair] += health) >= maxHealth)
                {
                    pirateShip[indexRepair] = maxHealth;
                }

            }
        }
        static void Defend(List<int> pirateShip, int startIndex, int endIndex, int damageFromWarship)
        {
            if (CheckIndexBoundery(pirateShip, startIndex) && CheckIndexBoundery(pirateShip, endIndex))
            {

                for (int i = startIndex; i <= endIndex; i++)
                {
                    if ((pirateShip[i] -= damageFromWarship) <= 0)
                    {
                        Console.WriteLine("You lost! The pirate ship has sunken.");
                        return;
                    }

                }
            }
        }
        static void Fire(List<int> warShip, int index, int damage)
        {
            if (CheckIndexBoundery(warShip, index))
            {
                if ((warShip[index] -= damage) <= 0)
                {
                    Console.WriteLine("You won! The enemy ship has sunken.");
                    return;
                }

            }
        }
        static bool CheckIndexBoundery(List<int> warship, int index)
        {
            if (index < 0 || index > warship.Count - 1)
            {
                return false;
            }
            return true;

        }
    }
}
