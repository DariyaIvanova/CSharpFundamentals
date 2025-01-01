


using System.Threading.Channels;

namespace _03.HeartDelivery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> neighbourhood = Console.ReadLine().Split("@").Select(int.Parse).ToList();

            string input = string.Empty;
            int lastPosition = 0;

            while ((input = Console.ReadLine()) != "Love!")
            {
                string[] jumps = input.Split().ToArray();
                int jump = int.Parse(jumps[1]);
                lastPosition = lastPosition + jump;
                if (!CheckJumpBoundery(neighbourhood, lastPosition))
                {
                    lastPosition = 0;
                }
                if (neighbourhood[lastPosition]==0)
                {
                    Console.WriteLine($"Place {lastPosition} already had Valentine's day.");
                }
                else
                {
                    neighbourhood[lastPosition] -= 2;
                    CheckValentineDay(neighbourhood, lastPosition);
                }

                
            }
            Console.WriteLine($"Cupid's last position was {lastPosition}.");
            if (CheckValentineDayAllHouses(neighbourhood))
            {
                Console.WriteLine("Mission was successful.");
                return;
            }
            int failedHouses=neighbourhood.Where(x=>x!=0).Count();
            Console.WriteLine($"Cupid has failed {failedHouses} places.");
        }

        static bool CheckValentineDayAllHouses(List<int> neighbourhood)
        {
            foreach (int i in neighbourhood)
            {
                if (i!=0)
                {
                    return false;
                }
            }
            return true;
        }

        static void CheckValentineDay(List<int> neighbourhood, int lastPosition)
        {
            if (neighbourhood[lastPosition]==0)
            {
                Console.WriteLine($"Place {lastPosition} has Valentine's day.");
            }
        }

        static bool CheckJumpBoundery(List<int> neighbourhood, int lastPosition)
        {
            if (lastPosition > neighbourhood.Count - 1)
            {
                return false;
            }
            return true;
        }       
    }
}
