using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.HouseParty
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            List<string> names = new List<string>();


            for (int i = 0; i < count; i++)
            {
                List<string> commands = Console.ReadLine().Split().ToList();
                string name = commands[0];
                int lengthCommand = commands.Count();

                switch (lengthCommand)
                {
                    case 3:
                        if (!names.Contains(name))
                        {
                            names.Add(name);
                        }
                        else
                        {
                            Console.WriteLine($"{name} is already in the list!");
                        }
                        break;

                    case 4:
                        if (names.Contains(name))
                        {
                            names.Remove(name);
                        }
                        else
                        {
                            Console.WriteLine($"{name} is not in the list!");
                        }
                        break;
                }
               
            }
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}
