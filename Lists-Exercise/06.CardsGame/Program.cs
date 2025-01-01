using System;
using System.Collections.Generic;
using System.Linq;

/*
20 30 40 50
10 20 30 40
 
10 20 30 40 50
50 40 30 30 10

 */

namespace _06.CardsGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> handOne = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> handTwo = Console.ReadLine().Split().Select(int.Parse).ToList();

            while ((handOne.Count > 0) && (handTwo.Count > 0))
            {
                if (handOne[0] > handTwo[0])
                {
                    int winningCard = handOne[0];
                    handOne.Add(handTwo[0]);
                    handOne.RemoveAt(0);
                    handTwo.RemoveAt(0);
                    handOne.Add(winningCard);
                }
                else if (handOne[0] < handTwo[0])
                {
                    int winningCard = handTwo[0];
                    handTwo.Add(handOne[0]);
                    handOne.RemoveAt(0);
                    handTwo.RemoveAt(0);
                    handTwo.Add(winningCard);
                }
                else
                {
                    handOne.RemoveAt(0);
                    handTwo.RemoveAt(0);
                }
            }

            if (handOne.Count>0)
            {
                Console.WriteLine($"First player wins! Sum: {handOne.Sum()}");return;
            }
            Console.WriteLine($"Second player wins! Sum: {handTwo.Sum()}");
        }
    }
}
