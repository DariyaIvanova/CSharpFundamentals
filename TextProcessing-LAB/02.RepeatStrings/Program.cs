using System.Text;

namespace _02.RepeatStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();

            StringBuilder resultedString=new StringBuilder();

            foreach (string str in input)
            {
                int length=str.Length;

                for (int i = 0; i < length; i++)
                {
                    resultedString.Append(str);
                }
            }
            Console.WriteLine(resultedString);
        }
    }
}
