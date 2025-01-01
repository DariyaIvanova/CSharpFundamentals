using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.ChangeList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();

            string input = "";

            while ((input=Console.ReadLine())!="end")
            {
                List<string> commands=input.Split().ToList();
                int element = int.Parse(commands[1]);

                switch (commands[0])
                {
                    case "Delete":
                        nums.RemoveAll(x => x == element); 
                        break;
                      
                    case "Insert":
                        int position = int.Parse(commands[2]);
                        nums.Insert(position, element);
                        break;
                }
            }
            Console.WriteLine(string.Join(" ", nums));
        }
    }
}
