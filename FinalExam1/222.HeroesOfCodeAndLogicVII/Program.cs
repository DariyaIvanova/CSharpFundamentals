



using static System.Net.Mime.MediaTypeNames;

namespace _222.HeroesOfCodeAndLogicVII
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            Dictionary<string, Hero> heroes = new Dictionary<string, Hero>();
            string input = string.Empty;

            for (int i = 0; i < count; i++)
            {
                input = Console.ReadLine();
                string[] heroAttributes = input.Split(" ").ToArray();
                string name=heroAttributes[0];
                int hitPoints=int.Parse(heroAttributes[1]);
                int manaPoints=int.Parse(heroAttributes[2]);

                heroes[name] = new Hero(name, hitPoints, manaPoints);

            }

            while ((input=Console.ReadLine())!="End")
            {
                string[] commands = input.Split(" - ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                string command = commands[0];
                string name=string.Empty;
                switch (command)
                {
                    case "CastSpell":
                         name = commands[1];
                        int manaPointsNeeded = int.Parse(commands[2]);
                        string spellName=commands[3];
                        CastSpellMethod(name, manaPointsNeeded, spellName, heroes);
                        break;
                    case "TakeDamage":
                        name = commands[1];
                        int demage = int.Parse(commands[2]);
                        string attacker=commands[3];
                        TakeDemageMethod(name, demage, attacker, heroes);
                        break;
                    case "Recharge":
                        name= commands[1];
                        int amount=int.Parse(commands[2]);
                        RechargeMethod(name, amount, heroes);
                        break;
                    case "Heal":
                        name=commands[1];
                        int healAmount=int.Parse(commands[2]);
                        HealMethod(name, healAmount, heroes);
                        break;
                }               
            }

            foreach (Hero hero in heroes.Values)
            {
                Console.WriteLine($"{hero.Name}");
                Console.WriteLine($"  HP: {hero.HitPoints}");
                Console.WriteLine($"  MP: {hero.ManaPoints}");
            }
        }

        private static void HealMethod(string name, int healAmount, Dictionary<string, Hero> heroes)
        {
            Hero hero = heroes[name];

            int originalHitPoints = hero.HitPoints;

            hero.HitPoints += healAmount;

            if (hero.HitPoints > 100)
            {
                hero.HitPoints = 100;
            }

            Console.WriteLine($"{name} healed for {hero.HitPoints - originalHitPoints} HP!");
        }

        private static void RechargeMethod(string name, int amount, Dictionary<string, Hero> heroes)
        {
            Hero hero = heroes[name];

            int originalManaPoints = hero.ManaPoints;

            hero.ManaPoints += amount;

            if (hero.ManaPoints > 200)
            {
                hero.ManaPoints = 200;
            }

            Console.WriteLine($"{name} recharged for {hero.ManaPoints - originalManaPoints} MP!");
        }

        private static void TakeDemageMethod(string name, int demage, string attacker, Dictionary<string, Hero> heroes)
        {
            Hero hero = heroes[name];

            hero.HitPoints -= demage;

            if (hero.HitPoints > 0)
            {
                Console.WriteLine($"{name} was hit for {demage} HP by {attacker} and now has {hero.HitPoints} HP left!");

                return;
            }

            Console.WriteLine($"{name} has been killed by {attacker}!");

            heroes.Remove(name);
        }

        private static void CastSpellMethod(string name, int manaPointsNeeded, string spellName, Dictionary<string, Hero> heroes)
        {
            if (heroes[name].ManaPoints>=manaPointsNeeded)
            {
                heroes[name].ManaPoints -= manaPointsNeeded;
                Console.WriteLine($"{name} has successfully cast {spellName} and now has {heroes[name].ManaPoints} MP!");
            }
            else
            {
                Console.WriteLine($"{name} does not have enough MP to cast {spellName}!");
            }
        }
    }
    class Hero
    {
        public Hero(string name, int hitPoints, int manaPoints)
        {
            Name = name;
            HitPoints = hitPoints;
            ManaPoints = manaPoints;
        }

        public string Name { get; set; }
        public int HitPoints { get; set; }
        public int ManaPoints { get; set; }
    }
}
