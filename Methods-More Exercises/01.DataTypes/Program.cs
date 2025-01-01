using System;

namespace _01.DataTypes
{
    internal class Program
    {
        static void Main()
        {
            string variableType = Console.ReadLine();
            string input = Console.ReadLine();

            switch (variableType)
            {

                case "int":
                    int intInput = int.Parse(input);
                    IntOperation(intInput);
                    break;
                case "real":
                    double doubleInput = double.Parse(input);
                    DoubleOperation(doubleInput);
                    break;
                case "string":                  
                    StringOperation(input);
                    break;

            }
            static void IntOperation(int input)
            {
                int result = input * 2;
                Console.WriteLine(result);
            }
            static void DoubleOperation(double input)
            {
                double result = input * 1.5;
                Console.WriteLine($"{result:f2}");
            }
            static void StringOperation(string input)
            {
                Console.WriteLine($"${input}$");
            }

        }
    }
}
