using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace _03.MemoryGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> nums = Console.ReadLine().Split().ToList();

            string input = string.Empty;

            int moves = 0;
            while ((input = Console.ReadLine()) != "end")
            {
                List <int> indexes = input.Split().Select(int.Parse).ToList();
                int firstIndex = indexes[0];
                int secondIndex = indexes[1];
                moves++;    

                if (firstIndex == secondIndex || !CheckIndexOutOfBounderies(nums, firstIndex) || !CheckIndexOutOfBounderies(nums, secondIndex))
                {
                    int middle = nums.Count / 2;
                    string addedElement = $"-{moves}a";
                    List<string> range = new List<string> { addedElement, addedElement };
                    nums.InsertRange(middle, range);
                    Console.WriteLine($"Invalid input! Adding additional elements to the board");
                }
                else
                {
                    if (nums[firstIndex] != nums[secondIndex])
                    {
                        Console.WriteLine("Try again!");
                        continue;
                    }
                    else
                    {
                        string element = nums[firstIndex];
                        indexes = indexes.OrderByDescending(x => x).ToList();
                        for (int i = 0; i < indexes.Count; i++)
                        {
                            nums.RemoveAt(indexes[i]);
                        }
                        Console.WriteLine($"Congrats! You have found matching elements - {element}!");
                        if (nums.Count==0)
                        {
                            Console.WriteLine($"You have won in {moves} turns!");
                            return;
                        }
                      
                    }
                }

            }
            if (nums.Count != 0)
            {
                Console.WriteLine($"Sorry you lose :(");
                Console.WriteLine(string.Join(" ", nums));
            }
        }

        static bool CheckIndexOutOfBounderies(List<string> numbers, int index)
        {
            if (index < 0 || index > numbers.Count - 1)
            {
                return false;
            }
            return true;
        }
    }
}
