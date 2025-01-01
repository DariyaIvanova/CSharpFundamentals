using System.Text.RegularExpressions;

namespace _11.MirrorWords
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
          
            string pattern = @"(#|@)([a-zA-Z]{3,})\1{2}([a-zA-Z]{3,})\1";
            Dictionary<string, string> MirrorStrings = new Dictionary<string, string>();    
            


            foreach (Match match in Regex.Matches(input, pattern))
            {

                MirrorStrings[match.Groups[2].Value] = match.Groups[3].Value;
               
            }
            if (MirrorStrings.Count == 0)
            {
                Console.WriteLine("No word pairs found!");
                Console.WriteLine("No mirror words!");
                return;
            }
            else
            {
                Console.WriteLine($"{MirrorStrings.Count} word pairs found!");
                foreach (KeyValuePair<string, string> pair in MirrorStrings)
                {
                    string currentStringValue = ReverseAString(pair.Value);
                    if (currentStringValue != pair.Key)
                    {
                        MirrorStrings.Remove(pair.Key);
                    }
                }
                if (MirrorStrings.Count == 0)
                {
                    Console.WriteLine("No mirror words!");
                    return;
                }
            }
            Console.WriteLine("The mirror words are:");
            List<string> mirrorsPairs=new List<string>();
            foreach (var pair in MirrorStrings)
            {
                mirrorsPairs.Add($"{pair.Key} <=> {pair.Value}");
            }
            Console.WriteLine(string.Join(", ", mirrorsPairs));
           
        }
        public static string ReverseAString(string thisString)
        {
            
            char[] inputArray = thisString.ToCharArray();
            Array.Reverse(inputArray);
            string output = new string(inputArray);
            return output;
        }
    }
}
