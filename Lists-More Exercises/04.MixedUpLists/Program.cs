using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.MixedUpLists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numsFisrt = Console.ReadLine().Split().Select(int.Parse).ToList();

            List<int> numsSecond = Console.ReadLine().Split().Select(int.Parse).ToList();

            List<int> mixedList = new List<int>();

            for (int i = 0; i < numsFisrt.Count; i++)
            {
                int secondListIndex = numsSecond.Count - 1 - i;
                if (secondListIndex < 0)
                {
                    break;
                }

                int currentFisrt = numsFisrt[i];
                mixedList.Add(numsFisrt[i]);
                numsFisrt.RemoveAt(i);

                int currentSecond = numsSecond[secondListIndex];
                mixedList.Add(numsSecond[secondListIndex]);
                numsSecond.RemoveAt(secondListIndex);
                i--;

            }
            int startRange;
            int endRange;

            if (numsFisrt.Count > numsSecond.Count)
            {
                if (numsFisrt[0] > numsFisrt[1])
                {
                    startRange = numsFisrt[1];
                    endRange = numsFisrt[0];
                }
                else
                {
                    startRange = numsFisrt[0];
                    endRange = numsFisrt[1];
                }
            }
            else
            {
                if (numsSecond[0] > numsSecond[1])
                {
                    startRange = numsSecond[1];
                    endRange = numsSecond[0];
                }
                else
                {
                    startRange = numsSecond[0];
                    endRange = numsSecond[1];
                }
            }

            mixedList=mixedList.Where(x=> x> startRange && x< endRange).ToList();
            mixedList.Sort();
            Console.WriteLine(string.Join(" ", mixedList));

        }
    }
}
