using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;

namespace _02.CarRace
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<int> timeNums = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            int middleIndex = timeNums.Count / 2;
            double leftRacer = 0;
            double rightRacer = 0;



            for (int i = 0; i < middleIndex; i++)
            {
                
                if (timeNums[i] == 0)
                {
                    leftRacer *= 0.80;
                }
                else
                {
                    leftRacer += timeNums[i];
                }
                
            }

            for (int i = timeNums.Count - 1; i >= middleIndex+1; i--)
            {
                if (timeNums[i] == 0)
                {
                    rightRacer *= 0.80;
                }
                else
                {
                    rightRacer += timeNums[i];
                }
            }
            
            if (rightRacer < leftRacer)
            {
                Console.WriteLine($"The winner is right with total time: {rightRacer:#.#}");
            }
            else
            {
                Console.WriteLine($"The winner is left with total time: {leftRacer:#.#}");
            }
        }
    }
}
