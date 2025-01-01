using System;

namespace _05.MultiplicationSign
{
    internal class Program
    {
        static void Main()
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());
            CheckSignAfterMultiplication(num1, num2, num3);
        }

        static void CheckSignAfterMultiplication(int num1, int num2, int num3)
        {

            if (num1 == 0 || num2 == 0 || num3 == 0)
            {
                Console.WriteLine("zero");return;
            }
            int countNegativeSigns = 0;
            if (num1 < 0) countNegativeSigns++;
            if (num2 < 0) countNegativeSigns++;
            if (num3 < 0) countNegativeSigns++;
            
            if (countNegativeSigns % 2 != 0)
            {
                Console.WriteLine("negative");
            }
            else
            {
                Console.WriteLine("positive");
            }

        }
    }
}
