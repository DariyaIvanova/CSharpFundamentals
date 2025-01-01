
using System.Security.Cryptography;
using System.Text;

namespace _03.TreasureFinder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> keys = Console.ReadLine().Split().Select(int.Parse).ToList();

            string input = string.Empty;

            while ((input = Console.ReadLine()) != "find")
            {

                string decryptedString = DecryptingStrings(input, keys);
                string type = GetTypeTresure(decryptedString);
                string coordinates = GetCoordinates(decryptedString);

                Console.WriteLine($"Found {type} at {coordinates}");
            }


        }

        private static string GetCoordinates(string decryptedString)
        {
            int startIndex = decryptedString.IndexOf('<');
            int endIndex= decryptedString.IndexOf('>');
            string resultedSubString=decryptedString.Substring(startIndex+1, endIndex-startIndex-1);

            return resultedSubString;
        }

        public static string GetTypeTresure(string decryptedString)
        {
            List<char> decryptedStringAsList = decryptedString.ToList();

            int startIndex = decryptedStringAsList.IndexOf('&');
            decryptedStringAsList.RemoveAt(startIndex);
            int endIndex = decryptedStringAsList.IndexOf('&') + 1;
            decryptedStringAsList.RemoveAt(endIndex);

            StringBuilder resultedSubString = new StringBuilder();
           
                for (int i = startIndex; i <endIndex-1 ; i++)
                {
                    resultedSubString.Append(decryptedStringAsList[i]);
                }
             
            return resultedSubString.ToString();
        }

        public static string DecryptingStrings(string input, List<int> keys)
        {
            StringBuilder decryptedString = new StringBuilder();
            for (int i = 0; i < input.Length; i++)
            {

                int currentAscciCode = input[i];

                char decryptedChar = (char)(currentAscciCode - keys[i % (keys.Count)]);
                decryptedString.Append(decryptedChar);

            }
            return decryptedString.ToString();
        }
    }
}
