namespace _3.Pirates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<City> allCities = new List<City>();


            string input = string.Empty;

            while ((input=Console.ReadLine())!="Sail")
            {
                string[] arguments = input.Split("||").ToArray();
                string currentCityName=arguments[0];
                int currentCityPopulation=int.Parse(arguments[1]);
                int currentCityGoldAmount = int.Parse(arguments[2]);

                City city = allCities.Find(c => c.CityName == currentCityName);
                bool shouldAdd = false; 



                if (city==null)
                {
                    city=new City();
                    city.CityName = currentCityName;
                    shouldAdd = true;
                }
                city.CityPopulation += currentCityPopulation;
                city.CityGold += currentCityGoldAmount;

                if (shouldAdd)
                {
                    allCities.Add(city);
                }
            }




            while ((input=Console.ReadLine())!="End")
            {
                string[] arguments = input.Split("=>").ToArray();
                string eVent = arguments[0];
                string currentCityName = arguments[1];

                City city = allCities.Find(c => c.CityName == currentCityName);

                if (eVent=="Plunder")
                {
                    int people = int.Parse(arguments[2]);
                    int gold = int.Parse(arguments[3]);

                    city.CityPopulation -= people;
                    city.CityGold -= gold;

                    Console.WriteLine($"{currentCityName} plundered! {gold} gold stolen, {people} citizens killed.");
                    
                    if (city.CityPopulation<=0||city.CityGold<=0)
                    {
                        allCities.Remove(city);
                        Console.WriteLine($" {currentCityName} has been wiped off the map!");
                    }

                }
                else if (eVent == "Prosper")
                {
                    int gold = int.Parse(arguments[2]);
                    if (gold < 0)
                    {
                        Console.WriteLine("Gold added cannot be a negative number!");
                        continue;
                    }
                    city.CityGold += gold;

                    Console.WriteLine($"{gold} gold added to the city treasury. {currentCityName} now has {city.CityGold} gold.");
                }


            }


            if (allCities.Count > 0)
            {
                Console.WriteLine($"Ahoy, Captain! There are {allCities.Count} wealthy settlements to go to:");

                foreach (City city in allCities)
                {
                    Console.WriteLine($"{city.CityName} -> Population: {city.CityPopulation} citizens, Gold: {city.CityGold} kg");
                }
            }
            else
            {
                Console.WriteLine("Ahoy, Captain! All targets have been plundered and destroyed!");
            }
        }
    }

    public class City
    {
        public string CityName { get; set; }
        public int CityPopulation { get; set; }
        public int CityGold { get; set; }

    }

}
