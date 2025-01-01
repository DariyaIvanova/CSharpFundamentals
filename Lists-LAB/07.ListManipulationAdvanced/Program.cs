/*
5 34 678 67 5 563 98
Contains 23
PrintOdd
GetSum
Filter >= 21
end
 */
using System;
using System.Collections.Generic;
using System.Linq;


namespace _07.ListManipulationAdvanced
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            string input = "";
           
            bool changeMade = false;
            while ((input = Console.ReadLine()) != "end")
            {
                List<string> commands = input.Split().ToList();

                string command = commands[0];
                int num;
                int index;
              

                switch (command)
                {
                    case "Add":
                        num = int.Parse(commands[1]);
                        numbers.Add(num);
                        changeMade = true;
                        break;

                    case "Remove":
                        num = int.Parse(commands[1]);
                        numbers.Remove(num);
                        changeMade = true;
                        break;

                    case "RemoveAt":
                        index = int.Parse(commands[1]);
                        numbers.RemoveAt(index);
                        changeMade = true;
                        break;

                    case "Insert":
                        num = int.Parse(commands[1]);
                        index = int.Parse(commands[2]);
                        numbers.Insert(index, num);
                        changeMade = true;
                        break;

                    case "Contains":
                        num = int.Parse(commands[1]);
                        CheckContainNumber(numbers, num);
                        break;
                    case "PrintEven":
                        PrintEvenNumbers(numbers);
                        break;
                    case "PrintOdd":
                        PrintOddNumbers(numbers);
                        break;
                    case "GetSum":
                        PrintSum(numbers);
                        break;
                    case "Filter":
                        string condition = commands[1];
                        num = int.Parse(commands[2]);
                        PrintFilteredList(numbers, condition, num);
                        break;
                }
            }
            if (changeMade)
            {
                Console.WriteLine(string.Join(" ", numbers));

            }
            
        }

        static void CheckContainNumber(List<int> numbers, int num)
        {
            Console.WriteLine(numbers.Contains(num) ? "Yes" : "No such number");
        }
        static void PrintEvenNumbers(List<int> numbers)
        {
            Console.WriteLine(string.Join(" ", numbers.Where(number => number % 2 == 0)));
        }
        static void PrintOddNumbers(List<int> numbers)
        {
            Console.WriteLine(string.Join(" ", numbers.Where(number => number % 2 != 0)));
        }
        static void PrintSum(List<int> numbers)
        {

            int sum = 0;
            for (int i = 0; i < numbers.Count; i++)
            {
                sum += numbers[i];
            }
            Console.WriteLine(sum);
        }
        static void PrintFilteredList(List<int> numbers, string condition, int num)
        {

            List<int> filteredList = new List<int>();
            switch (condition)
            {
                case "<":
                    filteredList = numbers.Where(x => x < num).ToList();
                    break;
                case ">":
                    filteredList = numbers.Where(x => x > num).ToList();
                    break;
                case "<=":
                    filteredList = numbers.Where(x => x <= num).ToList();
                    break;
                case ">=":
                    filteredList = numbers.Where(x => x >= num).ToList();
                    break;
            }

            Console.WriteLine(string.Join(" ", filteredList));
        }
    }
}
