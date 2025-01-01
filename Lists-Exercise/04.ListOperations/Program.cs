using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.ListOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            string input = "";

            while ((input = Console.ReadLine()) != "End")
            {
                List<string> commands = input.Split().ToList();
                string command = commands[0];
                int number;
                int index;
                switch (command)
                {
                    case "Add":
                        number = int.Parse(commands[1]);
                        numbers.Add(number);
                        break;
                    case "Insert":
                        number = int.Parse(commands[1]);
                        index = int.Parse(commands[2]);
                        if (!CheckIndexRange(numbers, index))
                        {
                            Console.WriteLine("Invalid index");
                            continue;
                        }
                        numbers.Insert(index, number);

                        break;
                    case "Remove":
                        index = int.Parse(commands[1]);
                        if (!CheckIndexRange(numbers, index))
                        {
                            Console.WriteLine("Invalid index");
                            continue;
                        }

                        numbers.RemoveAt(index);
                        break;
                    case "Shift":
                        string direction = commands[1];
                        int count = int.Parse(commands[2]);
                        int firstElement;
                        int lastElement;
                        int rotations = count % numbers.Count;
                        switch (direction)
                        {
                            case "left":
                                
                                
                                for (int i = 0; i < rotations; i++)
                                {
                                    firstElement = numbers[0];
                                    numbers = numbers.Skip(1).ToList();
                                    numbers.Add(firstElement);
                                }
                                break;
                            case "right":
                                                            
                                for (int i = 0; i < rotations; i++)
                                {
                                    lastElement = numbers[numbers.Count-1];
                                    numbers.RemoveAt(numbers.Count - 1);
                                    numbers.Insert(0, lastElement);
                                }
                                break;
                        }
                        break;
                }
            }

            Console.WriteLine(string.Join(" ", numbers));
        }

        static bool CheckIndexRange(List<int> nums, int index)
        {
            if (index >= 0 && index <= nums.Count - 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
