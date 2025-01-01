using System;
using System.Collections.Generic;
using System.Linq;
/*
 
Data Types, Objects, Lists
Add:Databases
Insert:Arrays:0
Remove:Lists
course start

 
 */

namespace _10.SoftUniCoursePlanning
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> schedule = Console.ReadLine().Split(", ").ToList();
            string command = string.Empty;

            while ((command = Console.ReadLine()) != "course start")
            {
                string[] arguments = command.Split(":");
                if (arguments[0] == "Add")
                {
                    schedule = AddTitle(schedule, arguments[1]);
                }
                else if (arguments[0] == "Insert")
                {
                    schedule = InsertTitle(schedule, arguments[1], int.Parse(arguments[2]));
                }
                else if (arguments[0] == "Remove")
                {
                    schedule = RemoveTitle(schedule, arguments[1]);
                }
                else if (arguments[0] == "Swap")
                {
                    schedule = SwapTitles(schedule, arguments[1], arguments[2]);
                }
                else if (arguments[0] == "Exercise")
                {
                    schedule = InsertExercises(schedule, arguments[1]);
                }

            }
            PrintSchedule(schedule);
        }

        private static void PrintSchedule(List<string> schedule)
        {
            int count = 1;
            schedule.ForEach(l=> Console.WriteLine($"{count++}.{l}"));
            
            //for (int i = 0; i < schedule.Count; i++)
            //{
            //    Console.WriteLine($"{i + 1}.{schedule[i]}");
            //}
        }

        static List<string> InsertExercises(List<string> schedule, string title)
        {
            string exerciseTitle = $"{title}-Exercise";
            if (!schedule.Contains(title))
            {
                AddTitle(schedule, title);
            }
            if (schedule.Contains(title) && !schedule.Contains(exerciseTitle))
            {
                int index = schedule.IndexOf(title);
                InsertTitle(schedule, exerciseTitle, index);
            }
            
            return schedule;
        }

        static List<string> SwapTitles(List<string> schedule, string firstTitle, string secondTitle)
        {
            if (schedule.Contains(firstTitle) && schedule.Contains(secondTitle))
            {
                int firstIndex = schedule.FindIndex(x => x == firstTitle);
                int secondIndex = schedule.FindIndex(x => x == secondTitle);


                string temp = schedule[firstIndex];
                schedule[firstIndex] = schedule[secondIndex];
                schedule[secondIndex] = temp;

                schedule = SwapExercise(schedule, firstTitle, secondIndex);
                schedule = SwapExercise(schedule, secondTitle, firstIndex);

            }
            return schedule;
        }

        static List<string> SwapExercise(List<string> schedule, string title, int titleIndex)
        {
            string exerciseTitle = $"{title}-Exercise";
            int index = schedule.FindIndex(l=>l==exerciseTitle);
            if (index>=0)
            {
                RemoveTitle(schedule, exerciseTitle);
                InsertTitle(schedule, exerciseTitle, titleIndex+1);
            }
            return schedule;
        }

        static List<string> RemoveTitle(List<string> schedule, string title)
        {
            schedule.Remove(title);
            string exerciseTitle = $"{title}-Exercise";

            int index = schedule.IndexOf(exerciseTitle);
            if (index!=-1)
            {
                RemoveTitle(schedule, exerciseTitle);
            }

            return schedule;
        }

        static List<string> InsertTitle(List<string> schedule, string title, int index)
        {
            if (!schedule.Contains(title))
            {
                schedule.Insert(index, title);
            }
            return schedule;
        }

        static List<string> AddTitle(List<string> schedule, string title)
        {
            if (!schedule.Contains(title))
            {
                schedule.Add(title);
            }

            return schedule;
        }
    }
}
