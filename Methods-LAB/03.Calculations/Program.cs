using System;

internal class Program
{
    static void Main()
    {
        string operation = Console.ReadLine();
        int num1 = int.Parse(Console.ReadLine());
        int num2 = int.Parse(Console.ReadLine());

        switch (operation)
        {
            case "add":
                AddNumbers(num1, num2);
                break;
            case "multiply":
                Multiplication(num1, num2);
                break;
            case "subtract":
                SubstracNumbers(num1, num2);
                break;
            case "divide":
                Division(num1, num2);
                break;
        }
    }

    static void Division(int num1, int num2)
    {
        int result = num1 / num2;
        Console.WriteLine(result);
    }

    static void SubstracNumbers(int num1, int num2)
    {
        int result = num1 - num2;
        Console.WriteLine(result);
    }

    static void Multiplication(int num1, int num2)
    {
        int result = num1 * num2;
        Console.WriteLine(result);
    }

    static void AddNumbers(int num1, int num2)
    {
        int sum = num1 + num2;
        Console.WriteLine(sum);
    }
}

