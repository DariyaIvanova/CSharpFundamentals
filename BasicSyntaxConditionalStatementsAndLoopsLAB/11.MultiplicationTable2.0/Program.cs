internal class Program
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        int multiplier = int.Parse(Console.ReadLine());

        do
        {
            Console.WriteLine($"{number} X {multiplier} = {number * multiplier}");
            multiplier++;
        } while (multiplier <= 10);
    }
}

