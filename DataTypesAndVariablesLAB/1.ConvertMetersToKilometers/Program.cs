  internal class Program
    {
        static void Main()
        {
        int meters = int.Parse(Console.ReadLine());
        decimal kilometers = (decimal)meters / 1000;
        Console.WriteLine($"{kilometers:f2}");
    }
    }

