using System.Text.RegularExpressions;

namespace _5.NetherRealms
{
    internal class Program
    {
        static void Main(string[] args)
        {
           List<Demon> demons= new List<Demon>();
            string input = Console.ReadLine();
            string[] demonNames = input.Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (string demonName in demonNames)
            {
                int health = GetHealth(demonName);
                decimal demage = GetDemage(demonName);
                Demon newDemon = new Demon();
                newDemon.Name = demonName;
                newDemon.Health = GetHealth(demonName);
                newDemon.Damage = GetDemage(demonName);
                demons.Add(newDemon);
            }

            demons=demons.OrderBy(demon => demon.Name).ToList();
            foreach (Demon demon in demons)
            {
                Console.WriteLine($"{demon.Name} - {demon.Health} health, {demon.Damage:f2} damage");
            }
        }

       static decimal GetDemage(string demonName)
        {
            decimal demage = 0;
            string pattern = @"[\-\+]?(?:\d+\.\d+|\d+)";
            foreach (Match match in Regex.Matches(demonName, pattern))
            {
                decimal number;
                decimal.TryParse(match.Value, out number);
                demage += number;
            }
            pattern = @"[\*|\/]";
            foreach (Match match in Regex.Matches(demonName, pattern))
            {
                if (match.Value=="*")
                {
                    demage *= 2;
                }
                else if (match.Value == "/")
                {
                    demage /= 2;
                }
            }

            return demage;
        }

        static int GetHealth(string demonName)
        {
            int health=0;
           
            string pattern = @"[^0-9+\-*/.]";
            foreach (Match match in Regex.Matches(demonName, pattern))
            {
                health += match.Value[0];
            }
            return health;
        }
    }
    internal class Demon
    {
        public string Name;
        public int Health;
        public decimal Damage;
    }
}
