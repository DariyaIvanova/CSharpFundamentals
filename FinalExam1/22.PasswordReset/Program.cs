


namespace _22.PasswordReset
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string originalPass = Console.ReadLine();

            string input = string.Empty;

            while ((input=Console.ReadLine())!="Done")
            {
                string[] commands = input.Split().ToArray();

                string command=commands[0];

                switch (command)
                {
                    case "TakeOdd":
                        originalPass = TakeOdd(originalPass);
                        Console.WriteLine(originalPass);
                        break;
                    case "Cut":
                        int index = int.Parse(commands[1]);
                        int length = int.Parse(commands[2]);
                        originalPass = Cut(originalPass, index, length);
                        Console.WriteLine(originalPass);
                        break;
                    case "Substitute":
                        string subString=commands[1];
                        string substitute = commands[2];
                        originalPass = Substitute(originalPass, subString, substitute);
                        
                        break;
                }
            }

            Console.WriteLine($"Your password is: {originalPass}");
        }

        private static string Substitute(string originalPass, string subString, string substitute)
        {
          
            if (originalPass.Contains(subString))
            {
               originalPass= originalPass.Replace(subString, substitute);
                Console.WriteLine(originalPass);
                return originalPass;
            }
            else
            {
                Console.WriteLine("Nothing to replace!");
                return originalPass;
            }

        }

        private static string Cut(string originalPass, int index, int length)
        {
            // Get the substring
            string substring = originalPass.Substring(index, length);

            // Remove the first occurrence of the substring
            int firstOccurrence = originalPass.IndexOf(substring);
            if (firstOccurrence != -1)
            {
                originalPass = originalPass.Remove(firstOccurrence, substring.Length);
            }
            return originalPass;
        }

        private static string TakeOdd(string password)
        {
            string result = new string(password.Where((c, i) => i % 2 != 0).ToArray());
            return result;

        }
    }
}
