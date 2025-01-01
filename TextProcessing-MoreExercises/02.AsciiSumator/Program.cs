using System.Text;

namespace _02.AsciiSumator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char firstChar = char.Parse(Console.ReadLine());
            char secondChar = char.Parse(Console.ReadLine());
            string input = Console.ReadLine();

            int sum = 0;
            int firstCharAscci = firstChar;
            int secondCharAscci = secondChar;

            if (firstCharAscci > secondCharAscci)
            {
                int temp = firstCharAscci;
                firstCharAscci = secondCharAscci;
                secondCharAscci = temp;
            }
            foreach (var ch in input)
            {
                if (ch > firstCharAscci && ch < secondCharAscci)
                {
                    sum += ch;

                }
            }

            Console.WriteLine(sum);
        }
    }
}
