
/*
 * 
 /, *, + and -

 */
using System;

namespace _11.MathOperations
{
    internal class Program
    {
        static void Main()
        {
            int num1 = int.Parse(Console.ReadLine());
            char @operator=char.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine(Calculate(num1, @operator, num2));
        }

        static double Calculate(int firstNumber, char @operator, int secondNumber)
        {
            double result=0;
            switch (@operator)
            {
                case '+':
                    result = firstNumber + secondNumber;
                    break;
                case '-':
                    result = firstNumber - secondNumber;
                    break;
                case '*':
                    result = firstNumber * secondNumber;
                    break;
                case '/':
                    result = firstNumber / secondNumber*1.0;
                    break;

            }

            return result; 
        }
    }
}
