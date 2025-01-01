namespace _04.WordFilter
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<string> fruits = Console.ReadLine()
                .Split()
                .Where(x => x.Length%2==0)
                .ToList();

            //foreach (string fruit in fruits)
            //{
            //    Console.WriteLine(fruit);
            //}
            Console.WriteLine(string.Join(Environment.NewLine, fruits));
        }
    }
}
