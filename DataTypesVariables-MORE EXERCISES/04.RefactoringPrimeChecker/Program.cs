using System;

namespace _04.RefactoringPrimeChecker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());

            for (int i = 2; i <= count; i++)
            {
                Console.WriteLine($"{i} -> {IsPrimeChecker(i)}");
            }
        }

        static string IsPrimeChecker(int number)
        {
            bool prime = true;
            string result = "true";
            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    prime = false;
                    result = "false";
                    break;
                }
            }
            return result;
        }
    }
}
