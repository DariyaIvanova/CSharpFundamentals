namespace _1.ValidUsernames
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] usernames = Console.ReadLine().Split(", ");
            foreach (var username in usernames)
            {
                if (username.Length<3 || username.Length>16)
                {
                    continue;
                }
                bool isValidName = username.All(character => char.IsLetterOrDigit(character) || character=='-'  || character=='_');
                if (isValidName)
                {
                    Console.WriteLine(username);
                }
            }

           
        }
    }
}
