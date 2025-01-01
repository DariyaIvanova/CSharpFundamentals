namespace _03.Substring
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string stringToBeRemoved = Console.ReadLine();
            int length = stringToBeRemoved.Length;
            string fullString = Console.ReadLine();

            while (fullString.Contains(stringToBeRemoved))
            {
                int index=fullString.IndexOf(stringToBeRemoved);
                fullString = fullString.Remove(index, length);
            }
            Console.WriteLine(fullString);
        }
    }
}
