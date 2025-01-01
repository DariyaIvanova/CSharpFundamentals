
namespace _01.ReverseStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = string.Empty;

            while ((input=Console.ReadLine())!="end")
            {
                string reversedString = ReverseStrings(input);
                Console.WriteLine($"{input} = {reversedString}");
            }
        }

        private static string ReverseStrings(string input)
        {
            char[] stringAsCharArray=input.ToCharArray();
            Array.Reverse(stringAsCharArray);
            string result = new string(stringAsCharArray);

            return result;
        }
    }
}
