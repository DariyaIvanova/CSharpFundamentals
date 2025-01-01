using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.ListManipulationBasics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            string input = "";

            while ((input = Console.ReadLine()) != "end")
            {
                List<string> commands = input.Split().ToList();
                int number;
                int index;
                switch (commands[0])
                {
                    case "Add":
                        number = int.Parse(commands[1]);
                        numbers.Add(number);
                        break;

                    case "Remove":
                        number = int.Parse(commands[1]);
                        numbers.Remove(number);
                        break;

                    case "RemoveAt":
                        index = int.Parse(commands[1]);
                        numbers.RemoveAt(index);
                        break;

                    case "Insert":
                        number=int.Parse(commands[1]);
                        index = int.Parse(commands[2]);
                        numbers.Insert(index, number);
                        break;
                }
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
