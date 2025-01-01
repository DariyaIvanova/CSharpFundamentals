using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.TheLift
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int waiting = int.Parse(Console.ReadLine());
            List<int> wagons = Console.ReadLine().Split().Select(int.Parse).ToList();
            int limit = 4;



            for (int i = 0; i < wagons.Count; i++)
            {
                int currentAdd = limit - wagons[i];
                if (currentAdd<=waiting)
                {
                    wagons[i] += currentAdd;
                    waiting -= currentAdd;
                }
                else
                {
                    wagons[i] += waiting;
                    waiting = 0;
                }
                if (!CheckFullness(wagons) && waiting == 0)
                {
                    Console.WriteLine("The lift has empty spots!");
                    Console.WriteLine(string.Join(' ', wagons));
                    return;
                }
                else if (CheckFullness(wagons) && waiting != 0)
                {
                    Console.WriteLine($"There isn't enough space! {waiting} people in a queue!");
                    Console.WriteLine(string.Join(' ', wagons));
                    return;
                }
                else if (CheckFullness(wagons) && waiting == 0)
                {
                    Console.WriteLine(string.Join(' ', wagons));
                }
                else if (!CheckFullness(wagons) && waiting != 0)
                {
                    continue;
                }             
            }
        }

        static bool CheckFullness(List<int> wagons)
        {
           
            foreach (int wagon in wagons)
            {
                if (wagon != 4)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
