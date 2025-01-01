using System;

namespace _06.BalancedBrackets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            string prev = "";
            int counter = 0;

            for (int i = 0; i < count; i++)
            {
                string input = Console.ReadLine().Trim();

                if (input=="(")
                {
                    if (prev==input)
                    {
                        Console.WriteLine("UNBALANCED");
                        return;
                    }
                    prev = input;
                    counter++;
                }
                if (input == ")")
                {
                    if (counter==0)
                    {
                        Console.WriteLine("UNBALANCED");
                        return;
                    }
                    prev = "";
                    counter--;
                }
            }
            if (counter == 0)
            {
                Console.WriteLine("BALANCED");
            }
            else
            {
                Console.WriteLine("UNBALANCED");
            }
        }
    }
}
