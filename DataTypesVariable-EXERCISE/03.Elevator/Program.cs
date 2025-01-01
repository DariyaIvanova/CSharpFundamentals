using System;

namespace _03.Elevator
{
    internal class Program
    {
        static void Main()
        {
            int peopleCount = int.Parse(Console.ReadLine());
            int capacity=int.Parse(Console.ReadLine());


            int coursesCount = (int)Math.Ceiling((double)peopleCount / capacity);
           
            Console.WriteLine(coursesCount);
        }
    }
}
