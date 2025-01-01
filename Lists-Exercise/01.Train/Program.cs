using System;
using System.Collections.Generic;
using System.Linq;

/*
32 54 21 12 4 0 23
75
Add 10
Add 0
30
10
75
end 
 */

namespace _01.Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
           List<int> wagons=Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            int capacity = int.Parse(Console.ReadLine());

            string input = "";

            while ((input=Console.ReadLine())!="end")
            {
                List<string> commands = input.Split().ToList();

                
                if (commands[0] == "Add")
                {
                    int newWagon = int.Parse(commands[1]);
                    wagons.Add(newWagon);
                }
                else
                {
                    int passangersToAdd = int.Parse(commands[0]);

                    for (int i = 0; i < wagons.Count; i++)
                    {
                        int currentCountInWagon = wagons[i];
                        if (currentCountInWagon + passangersToAdd <= capacity)
                        {
                            wagons[i] += passangersToAdd;break;
                        }
                        else
                        {
                            continue;
                        }
                    }
                }
            }
            Console.WriteLine(string.Join(" ", wagons));
        }
    }
}
