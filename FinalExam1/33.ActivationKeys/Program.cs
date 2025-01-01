

namespace _33.ActivationKeys
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string rawActivationKey = Console.ReadLine();

            string input = string.Empty;

            while ((input = Console.ReadLine()) != "Generate")
            {
                string[] arguments = input.Split(">>>").ToArray();

                string command = arguments[0];

                switch (command)
                {
                    case "Contains":
                        string subString = arguments[1];
                        if (rawActivationKey.Contains(subString))
                        {
                            Console.WriteLine($"{rawActivationKey} contains {subString}");
                        }
                        else
                        {
                            Console.WriteLine("Substring not found!");
                        }
                        break;
                    case "Flip":
                        string typeCase = arguments[1];
                        int startIndex = int.Parse(arguments[2]);
                        int endIndex = int.Parse(arguments[3]);
                        rawActivationKey = ChangeCase(rawActivationKey, startIndex, endIndex, typeCase);
                        Console.WriteLine(rawActivationKey);
                        break;
                    case "Slice":
                        int startIndexSlice = int.Parse(arguments[1]);
                        int endIndexSlice = int.Parse(arguments[2]);
                        rawActivationKey = SliceTheString(rawActivationKey, startIndexSlice, endIndexSlice);
                        Console.WriteLine(rawActivationKey);
                        break;
                }
            }
            Console.WriteLine($"Your activation key is: {rawActivationKey}");
        }

        private static string SliceTheString(string rawActivationKey, int startIndex, int endIndex)
        {
            string before = rawActivationKey.Substring(0, startIndex);
            string target = rawActivationKey.Remove(startIndex, endIndex-startIndex);
            string after = rawActivationKey.Substring(endIndex);
            return before + after;
        }

        private static string ChangeCase(string rawActivationKey, int startIndex, int endIndex, string typeCase)
        {
            string before = rawActivationKey.Substring(0,startIndex);
            string target = rawActivationKey.Substring(startIndex, endIndex-startIndex);
            string after =rawActivationKey.Substring(endIndex);

            bool toUpper = (typeCase=="Upper");

            target = toUpper ? target.ToUpper() : target.ToLower();
            return before+ target+ after;
        }
    }
}
