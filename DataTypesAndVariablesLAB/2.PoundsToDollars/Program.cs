internal class Program
    {
        static void Main()
        {
        decimal poundsUK = decimal.Parse(Console.ReadLine());
        decimal toDollars = poundsUK * 1.31m;
        Console.WriteLine($"{toDollars:f3}");
    }
    }

