using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.DrumSet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal budget = decimal.Parse(Console.ReadLine());
            List<int> initialDrumSet = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> drumSet = new List<int>();
            for (int i = 0; i < initialDrumSet.Count; i++)
            {
                drumSet.Add(initialDrumSet[i]);
            }
            string input = string.Empty;
            while ((input=Console.ReadLine()) != "Hit it again, Gabsy!")
            {
                int hitPower = int.Parse(input);
                drumSet = PerformHitPower(drumSet, hitPower);
                for (int i = 0; i < drumSet.Count; i++)
                {
                    if (drumSet[i]<=0)
                    {
                        
                        decimal valueToWithDraw = initialDrumSet[i] * 3;
                        if (valueToWithDraw <= budget)
                        {
                            int initialValue = initialDrumSet[i];
                            drumSet[i] = initialValue;
                            budget -= valueToWithDraw;
                        }
                        else
                        {
                            drumSet[i] = 0; // it acts as deleting at this time
                        }
                        
                    }
                }
            }

            Console.WriteLine(string.Join(" ", drumSet.Where(x=>x!=0)));
            Console.WriteLine($"Gabsy has {budget:f2}lv.");

        }

        static List<int> PerformHitPower(List<int> drumset, int hitPower)
        {
           
            for (int i = 0; i < drumset.Count; i++)
            {
                drumset[i] -= hitPower;
            }
            return drumset;
        }
    }
}
