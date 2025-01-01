 internal class Program
    {
        static void Main(string[] args)
        {
        int numFirst = int.Parse(Console.ReadLine());
        int numSecond=int.Parse(Console.ReadLine());
        int numThird = int.Parse(Console.ReadLine());
        int numFourth = int.Parse(Console.ReadLine());

        int result = ((numFirst + numSecond) / numThird) * numFourth;

        Console.WriteLine(result);


    }
}

