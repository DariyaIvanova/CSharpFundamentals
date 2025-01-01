internal class Program
{
    static void Main()
    {
        char[] charArray = new char[3];

        for (int i = 0; i <3; i++)
        {
            char symbol = char.Parse(Console.ReadLine());
            charArray[i]= symbol;
        }
        Array.Reverse(charArray);
        Console.WriteLine(string.Join(" ", charArray));
    }
}

