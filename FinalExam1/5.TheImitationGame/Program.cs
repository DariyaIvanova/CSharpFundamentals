namespace _5.TheImitationGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string encryptedMessage = Console.ReadLine();

            string input = string.Empty;
            while ((input=Console.ReadLine())!="Decode")
            {
                string[] commands = input.Split("|").ToArray();
                string command=commands[0];
                switch (command)
                {
                    case "Move":
                        int numberOfLetters = int.Parse(commands[1]);
                        string firstPart=encryptedMessage.Substring(0, numberOfLetters);
                        encryptedMessage=encryptedMessage.Remove(0, numberOfLetters);
                        encryptedMessage = encryptedMessage+firstPart;
                       
                        break;
                    case "Insert":
                        int index=int.Parse(commands[1]);
                        string value=commands[2];
                        encryptedMessage = encryptedMessage.Insert(index, value);
                       
                        break;
                    case "ChangeAll":
                        string substring = commands[1];
                        string replacement = commands[2];
                        if (encryptedMessage.Contains(substring))
                        {
                            encryptedMessage = encryptedMessage.Replace(substring, replacement);
                        }
                       
                        break;

                }
            }
           Console.WriteLine($"The decrypted message is: {encryptedMessage}");
        }
    }
}
