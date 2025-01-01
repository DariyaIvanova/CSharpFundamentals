using System.Runtime.InteropServices;

namespace _1.SecretChat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string concealedMessage=Console.ReadLine();

            string input = string.Empty;

            while ((input=Console.ReadLine())!="Reveal")
            {
                string[] commands=input.Split(":|:", StringSplitOptions.RemoveEmptyEntries).ToArray();

                string command = commands[0];

                switch (command)
                {
                    case "InsertSpace":
                        int index = int.Parse(commands[1]);
                        concealedMessage = InsertSpace(concealedMessage,index);
                        break;
                    case "Reverse":
                        string subString=commands[1];
                        concealedMessage = ReverseSubString(concealedMessage, subString);
                        break;
                    case "ChangeAll":
                        string substring=commands[1];
                        string replacement=commands[2];
                        concealedMessage = ChangeAll(concealedMessage, substring, replacement);
                        break;
                }
                
            }
            Console.WriteLine($"You have a new text message: {concealedMessage}");
        }

        private static string ChangeAll(string concealedMessage, string substring, string replacement)
        {
            string resulted=concealedMessage.Replace(substring, replacement);
            Console.WriteLine(resulted);
            return resulted;
        }

        private static string ReverseSubString(string concealedMessage, string subString)
        {
            if (concealedMessage.Contains(subString))
            {
                int indexOfSubstring=concealedMessage.IndexOf(subString);
                string beforeString = concealedMessage.Substring(0, indexOfSubstring);
                string afterString = concealedMessage.Substring(indexOfSubstring+subString.Length);
                string reversedString = MyReverseMethod(subString);
                string resulted = beforeString + afterString + reversedString;
                Console.WriteLine(resulted);
                return resulted ;  
            }
            else
            {
                Console.WriteLine("error");
                return concealedMessage;
            }
        }

        private static string MyReverseMethod(string subString)
        {
            string result = string.Empty;
            char[] array= subString.ToCharArray();
            Array.Reverse(array);
            result=new string(array);
            return result;
        }

        private static string InsertSpace(string concealedMessage,int index)
        {
            string message = concealedMessage.Insert(index, " ");
            Console.WriteLine(message);
            return message;
            
        }
    }
}
