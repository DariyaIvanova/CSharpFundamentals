
/*
 1 3 5 7 9
exchange 1 => 5 7 9 1 3
exchange 3 => 3 5 7 9 1
 */

using System;
using System.Linq;


namespace _11.ArrayManipulator
{
    internal class Program
    {
        static void Main()
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int arrLength = numbers.Length;
            string command = "";
            while ((command = Console.ReadLine()) != "end")
            {
                string[] commands = command.Split(" ");
                string commandToDo = commands[0];
                string type = "";
                int count = 0;
                switch (commandToDo)
                {
                    case "exchange":
                        int index = int.Parse(commands[1]);
                        numbers = ExchangeArrayByIndex(index, numbers);
                        break;

                    case "max":
                        type = commands[1];
                        PrintMaxEvenOrOddNUmberIndex(numbers, type);
                        break;

                    case "min":
                        type = commands[1];
                        PrintMinEvenOrOddNUmberIndex(numbers, type);
                        break;

                    case "first":
                        count = int.Parse(commands[1]);
                        type = commands[2];
                        PrintFirstEvenOrOddElements(count, numbers, type);
                        break;

                    case "last":
                        count = int.Parse(commands[1]);
                        type = commands[2];
                        PrintLastEvenOrOddElements(count, numbers, type);
                        break;
                }
            }
            Console.WriteLine($"[{string.Join(", ", numbers)}]");
        }

        static int[] ExchangeArrayByIndex(int index, int[] array)
        {

            if (CheckForOutOfRange(array, index))
            {
                Console.WriteLine("Invalid index");
                return array;
            }

            int[] newExchangedArr = new int[array.Length];
            int countIndexes = 0;

            for (int i = index + 1; i < array.Length; i++)
            {
                newExchangedArr[countIndexes++] = array[i];
            }
            for (int j = 0; j <= index; j++)
            {
                newExchangedArr[countIndexes++] = array[j];
            }
            return newExchangedArr;
        }
        static void PrintMaxEvenOrOddNUmberIndex(int[] numbers, string type)
        {
            int maxEvenOrOddNumber = int.MinValue;
            int maxEvenOrOddIndex = -1;

            for (int i = 0; i < numbers.Length; i++)
            {
                int currentNum = numbers[i];
                if (IsOddOrEvenAsWanted(type, currentNum))
                {
                    if (currentNum >= maxEvenOrOddNumber)
                    {
                        maxEvenOrOddNumber = currentNum;
                        maxEvenOrOddIndex = i;
                    }
                }
            }
            PrintIndex(maxEvenOrOddIndex);
        }
        static void PrintMinEvenOrOddNUmberIndex(int[] numbers, string type)
        {
            int minEvenOrOddNumber = int.MaxValue;
            int minEvenOrOddIndex = -1;

            for (int i = 0; i < numbers.Length; i++)
            {
                int currentNum = numbers[i];
                if (IsOddOrEvenAsWanted(type, currentNum))
                {
                    if (currentNum <= minEvenOrOddNumber)
                    {
                        minEvenOrOddNumber = currentNum;
                        minEvenOrOddIndex = i;
                    }
                }
            }
            PrintIndex(minEvenOrOddIndex);
        }
        static void PrintFirstEvenOrOddElements(int count, int[] numbers, string type)
        {
            if (count > numbers.Length)
            {
                Console.WriteLine("Invalid count");
                return;
            }
            string firstElements = "";
            int counter = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                int currentNumber = numbers[i];
                if (IsOddOrEvenAsWanted(type, currentNumber))
                {
                    firstElements += $"{currentNumber}, ";
                    counter++;
                    if (counter >= count)
                    {
                        break;
                    }
                }
            }
            Console.WriteLine($"[{firstElements.Trim(' ', ',')}]");
        }
        static void PrintLastEvenOrOddElements(int count, int[] numbers, string type)
        {
            if (count > numbers.Length)
            {
                Console.WriteLine("Invalid count");
                return;
            }
            string lastElements = "";
            int counter = 0;

            for (int i = numbers.Length - 1; i >= 0; i--)
            {
                int currentNumber = numbers[i];
                if (IsOddOrEvenAsWanted(type, currentNumber))
                {
                    lastElements = $"{currentNumber}, " + lastElements;
                    counter++;
                    if (counter >= count)
                    {
                        break;
                    }
                }
            }
            Console.WriteLine($"[{lastElements.Trim(' ', ',')}]");
        }
        static bool CheckForOutOfRange(int[] numbers, int index)
        {
            return index < 0 || index >= numbers.Length;
        }
        static bool IsOddOrEvenAsWanted(string type, int currentNum)
        {
            return (type == "even" && currentNum % 2 == 0) ||
               (type == "odd" && currentNum % 2 != 0);
        }
        static void PrintIndex(int maxEvenOrOddIndex)
        {
            if (maxEvenOrOddIndex != -1)
            {
                Console.WriteLine(maxEvenOrOddIndex);
            }
            else
            {
                Console.WriteLine("No matches");
            }
        }
    }
}
