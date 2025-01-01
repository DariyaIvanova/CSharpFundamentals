using System.Text;

namespace _04.CaesarCipher

//Programming is cool!
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            StringBuilder encrypted = new StringBuilder();

            for (int i = 0; i < input.Length; i++)
            {
                int currAscciCode = input[i];
                char newChar = (char)(currAscciCode + 3);
                encrypted.Append(newChar);
            }
            Console.WriteLine(encrypted);
        }

    }
}
