internal class Program
{
    static void Main()
    {

        string result = "";
        for (int i = 0; i < 3; i++)
        {
            result += char.Parse(Console.ReadLine());
        }
        Console.WriteLine(result);
    }
}

