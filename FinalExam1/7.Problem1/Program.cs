namespace _7.Problem1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string initialInput = Console.ReadLine();
            string input = string.Empty;

            while ((input = Console.ReadLine())!="Done")
            {
                string[] commands= input.Split(" ").ToArray();
                string command=commands[0];

                switch (command)
                {
                    case "Change":
                        char ch = char.Parse(commands[1]);
                        char replacement=char.Parse(commands[2]);
                        initialInput = initialInput.Replace(ch, replacement);
                        Console.WriteLine(initialInput);
                        break;

                    case "Includes":                       
                        string subString = commands[1];
                        bool isIncluded=initialInput.Contains(subString);
                        Console.WriteLine(isIncluded);
                        break;

                    case "End":
                        string subStringEnd=commands[1];
                        int lengthSubstring = subStringEnd.Length;
                        bool checkEnd = false;

                        if (initialInput.Length>=subStringEnd.Length)
                        {
                            string endOfString = initialInput.Substring(initialInput.Length - lengthSubstring, lengthSubstring);
                            if (endOfString==subStringEnd)
                            {
                                checkEnd = true;
                            }
                        }
                        Console.WriteLine(checkEnd);
                        break;
                    case "Uppercase":
                        initialInput = initialInput.ToUpper();
                        Console.WriteLine(initialInput);
                        break;
                    case "FindIndex":
                        char character=char.Parse(commands[1]);
                        int foundIndex=initialInput.IndexOf(character);
                        if (foundIndex!=-1)
                        {
                            Console.WriteLine(foundIndex);
                        }
                        break;
                    case "Cut":
                        int startIndex = int.Parse(commands[1]);
                        int count=int.Parse(commands[2]);
                        if (!(startIndex<0 && startIndex> initialInput.Length-1))
                        {
                            string cuttedString = initialInput.Substring(startIndex, count);
                            Console.WriteLine(cuttedString);
                        }
                        
                        break;
                }

            }


        }
    }
}
