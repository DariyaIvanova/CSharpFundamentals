internal class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        decimal totalSum = 0;

        for (int i = 0; i < n; i++)
        {
            decimal currentNum=decimal.Parse(Console.ReadLine());
            totalSum += currentNum;
           
        }
        Console.WriteLine(totalSum);

    }
}

