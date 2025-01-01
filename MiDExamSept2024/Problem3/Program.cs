namespace Problem3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> listWords = Console.ReadLine().Split().ToList();
            string input = string.Empty;

            while ((input=Console.ReadLine())!="Stop")
            {
                List<string> commands = input.Split().ToList();
                string command = commands[0];

                switch (command)
                {
                    case "Delete":
                        int index = int.Parse(commands[1]);
                        int indexAfter = index + 1;

                        if (!(indexAfter<0 || indexAfter> listWords.Count-1))
                        {
                            listWords.RemoveAt(indexAfter);
                        }

                        break;
                    case "Swap":
                        string firstWord = commands[1];
                        string secondWord = commands[2];

                        if (listWords.Contains(firstWord)&&listWords.Contains(secondWord))
                        {
                            int firstWordIndex = listWords.IndexOf(firstWord);
                            int secondWordIndex = listWords.IndexOf(secondWord);

                            string temp = listWords[firstWordIndex];
                            listWords[firstWordIndex] = listWords[secondWordIndex];
                            listWords[secondWordIndex] = temp;

                        }
                        break;
                    case "Put":

                        string word = commands[1];
                        int putIndex = int.Parse(commands[2]);
                        int putBeforeIndex = putIndex - 1;

                        if (putIndex==listWords.Count)
                        {
                            listWords.Add(word);
                        }
                        else if (!(putBeforeIndex<0||putBeforeIndex>listWords.Count))
                        {
                            listWords.Insert(putBeforeIndex, word);
                        }

                        break;
                    case "Sort":
                        listWords.Sort();
                        listWords.Reverse();
                        break;
                    case "Replace":

                        string word1 = commands[1];
                        string word2 = commands[2];

                        if (listWords.Contains(word2))
                        {
                            int indexWord2 = listWords.IndexOf(word2);
                            listWords[indexWord2]=word1;

                        }
                        break;
                }
            }
            Console.WriteLine(string.Join(" ", listWords));
        }
    }
}
