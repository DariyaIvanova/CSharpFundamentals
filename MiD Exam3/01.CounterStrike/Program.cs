namespace _01.CounterStrike
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int initialEnergy=int.Parse(Console.ReadLine());

            string input=string.Empty;
            int counterBattles = 0;

            while ((input=Console.ReadLine())!="End of battle")
            {
                int distance = int.Parse(input);
                if (distance <= initialEnergy)
                {
                    initialEnergy -= distance;
                    counterBattles++;
                    if (counterBattles%3==0)
                    {
                        initialEnergy += counterBattles;
                    }

                }
                else
                {
                    Console.WriteLine($"Not enough energy! Game ends with {counterBattles} won battles and {initialEnergy} energy");
                    return;
                }
                
            }
            Console.WriteLine($"Won battles: {counterBattles}. Energy left: {initialEnergy}");
        }
    }
}
