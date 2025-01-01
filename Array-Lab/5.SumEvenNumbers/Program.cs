using System.Security.Cryptography.X509Certificates;

internal class Program
{
    static void Main()
    {
        int sum = Console.ReadLine().Split().Select(int.Parse).ToArray().Where(x => x % 2==0).Sum();
        Console.WriteLine(sum);
    }
}

