internal class Program
{
    static void Main()
    {
        string input = Console.ReadLine();

        char[] inputArray = input.ToCharArray();
        Array.Reverse(inputArray);
        string output = new string(inputArray);
        Console.WriteLine(output);
    }
}

