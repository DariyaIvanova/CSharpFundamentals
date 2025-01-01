internal class Program
{
    static void Main()
    {
        char charInput = char.Parse(Console.ReadLine());
        if (char.IsUpper(charInput))
        {Console.WriteLine("upper-case");}
        else Console.WriteLine("lower-case");
    }
}

