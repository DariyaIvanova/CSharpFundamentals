using System;

namespace _04.TribonacciSequence
{
    internal class Program
    {
        static void Main()
        {
            int num = int.Parse(Console.ReadLine());
            int[] tribonacciArray = TribonacciSequence(num);
            Console.WriteLine(string.Join(" ", tribonacciArray));
        }

        static int[] TribonacciSequence(int range)
        {
            int[] result = new int[range];
            switch (range)
            {
                case 1:
                    result[0] = 1;
                    break;
                case 2:
                    result[0] = 1;
                    result[1] = 1;
                    break;
                case 3:
                    result[0] = 1;
                    result[1] = 1;
                    result[2] = 2;  
                    break;
                default:
                    result[0] = 1;
                    result[1] = 1;
                    result[2] = 2;
                    for (int i = 3; i < range; i++)
                    {
                        int currNum = result[i - 1] + result[i - 2] + result[i - 3];
                        result[i] = currNum;
                    }
                    break;
            }
            return result;
        }
    }
}
