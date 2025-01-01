namespace _1.RandomizeWords
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringRandomizer randomizer = new StringRandomizer();
            randomizer.Input = Console.ReadLine();
            randomizer.RandomizeInput();

            foreach (string item in randomizer.RandomizedInput)
            {
                Console.WriteLine(item);
            }
        }


        public class StringRandomizer
        {
            public string Input { get; set; }
            public List<string>  RandomizedInput { get; set; }
            
            public void RandomizeInput()
            {
                RandomizedInput = new List<string>();
                List<string> splitted = Input.Split(" ").ToList();
                Random random = new Random();

                int count = splitted.Count;
                for (int i = 0; i < count; i++)
                {
                    int index = random.Next(0, splitted.Count);
                    RandomizedInput.Add(splitted[index]);
                    splitted.RemoveAt(index);
                }
            }
        }

    }
}
