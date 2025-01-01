using System;
using System.Collections.Generic;
using System.Linq;

namespace _08.AnonymousThreat
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<string> list = Console.ReadLine().Split().ToList();
            string command = string.Empty;
            while ((command = Console.ReadLine()) != "3:1")
            {
                string[] arguments = command.Split();
                switch (arguments[0])
                {
                    case "merge":
                        int startIndex = int.Parse(arguments[1]);
                        int endIndex = int.Parse(arguments[2]);

                        list = Merge(list, startIndex, endIndex);

                        break;

                    case "divide":
                        int index = int.Parse(arguments[1]);
                        int partitions = int.Parse(arguments[2]);
                        list = Divide(list, index, partitions);

                        break;
                }
            }
            Console.WriteLine(string.Join(" ", list));

        }

        static List<string> Merge(List<string> list, int startIndex, int endIndex)
        {
            startIndex = Clamp(startIndex, 0, list.Count - 1);
            endIndex = Clamp(endIndex, 0, list.Count - 1);

            List<string> range = list.GetRange(startIndex, endIndex - startIndex + 1);
            string mergedStr = string.Join(string.Empty, range);
            list.RemoveRange(startIndex, endIndex - startIndex + 1);
            list.Insert(startIndex, mergedStr);

            return list;
        }


        static List<string> Divide(List<string> list, int index, int partitions)
        {
            if (partitions <= 0)
            {
                return list;
            }
            string element = list[index];
            List<string> newElements = new List<string>();

            int subLength = element.Length / partitions;   //5/3 = 1 (2 elements by 1 length)
            int remainingChars = element.Length % partitions;   //5%3 = 2 (1 element by 2 length)


            int elementIndex = 0;
            for (int i = 0; i < partitions; i++)
            {
                string newString = "";
                for (int j = 0; j < subLength; j++)
                {
                    newString += element[elementIndex];
                    elementIndex++;
                }
                newElements.Add(newString);

            }
            if (remainingChars > 0 && newElements.Count > 0)
            {
                for (int i = elementIndex; i < element.Length; i++)
                {
                    newElements[newElements.Count - 1] += element[i];
                }
            }

            list.RemoveRange(index, 1);
            list.InsertRange(index, newElements);



            return list;
        }

        static int Clamp(int value, int min, int max)
        {
            if (value < min)
            {
                value = min;
            }
            else if (value > max)
            {
                value = max;
            }
            return value;
        }
    }
}

