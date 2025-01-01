using System;
using System.Collections.Generic;
using System.Linq;
// 1 2 3 |4 5 6 |  7  8
namespace _07.AppendArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> numsByLists = new List<string>();
            List<int> result= new List<int>();  
            string input = Console.ReadLine();

            numsByLists = input.Split("|", StringSplitOptions.RemoveEmptyEntries).ToList();
            for (int i = 0; i < numsByLists.Count; i++)
            {
                numsByLists[i] = numsByLists[i].Trim();
            }

            numsByLists.Reverse();
            for (int i = 0; i < numsByLists.Count; i++)
            {
                List<int> currentList = numsByLists[i].Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
                for (int j = 0; j < currentList.Count; j++)
                {
                    result.Add(currentList[j]);
                }               
            }
            Console.WriteLine(string.Join(" ", result));
        }
    }
}
