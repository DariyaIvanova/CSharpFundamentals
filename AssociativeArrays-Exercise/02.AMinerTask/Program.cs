namespace _02.AMinerTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary <string, uint> miner = new Dictionary<string, uint>();

            string resource;
            uint quantity;

           
            while ((resource=Console.ReadLine())!="stop")
            {
                if (!miner.ContainsKey(resource))
                {
                    miner.Add(resource, 0);
                }
                quantity=uint.Parse(Console.ReadLine());
                miner[resource] += quantity;
            }

            foreach (KeyValuePair<string, uint> item in miner)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
