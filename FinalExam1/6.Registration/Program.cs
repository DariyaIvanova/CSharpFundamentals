namespace _6.Registration
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userName=Console.ReadLine();

            string input=string.Empty;

            while ((input=Console.ReadLine())!="Registration")
            {
                string[] commands = input.Split(" ").ToArray();
                string command=commands[0];

                switch (command)
                {
                    case "Letters":
                        string caseType=commands[1];
                        if (caseType=="Lower")
                        {
                            userName = userName.ToLower();
                            Console.WriteLine(userName);
                        }
                        else if (caseType == "Upper")
                        {
                            userName = userName.ToUpper();
                            Console.WriteLine(userName);

                        }
                        break;

                    case "Reverse":
                        int startIndex = int.Parse(commands[1]);
                        int endIndex = int.Parse(commands[2]);


                        if (!(startIndex<0 &&endIndex>userName.Length-1))
                        {
                            string cuttedString = userName.Substring(startIndex, endIndex - startIndex + 1);
                            char[] stringArray = cuttedString.ToCharArray();
                            Array.Reverse(stringArray);
                            cuttedString = new string(stringArray);
                            Console.WriteLine(cuttedString);
                        }
                        else
                        {
                            continue;
                        }                       
                        break;

                    case "Substring":
                        string substring = commands[1];

                        if (userName.Contains(substring))
                        {
                            int indexSubstring = userName.IndexOf(substring);
                            string before=userName.Substring(0, indexSubstring);
                            string after=userName.Substring(indexSubstring+substring.Length);
                            Console.WriteLine(before+after);
                        }
                        else
                        {
                            Console.WriteLine($"The username {userName} doesn't contain {substring}.");
                        }
                        break;

                    case "Replace":

                        char ch = char.Parse(commands[1]);
                        userName = userName.Replace(ch, '-');
                        Console.WriteLine(userName);
                        break;

                    case "IsValid":
                        char character = char.Parse(commands[1]);
                        if (userName.Contains(character))
                        {
                            Console.WriteLine($"Valid username.");
                        }
                        else
                        {
                            Console.WriteLine($"{character} must be contained in your username.");
                        }
                        break;


                }
            }
        }
    }
}
