internal class Program
{
    static void Main()
    {
        string userName = Console.ReadLine();

        char[] stringArray = userName.ToCharArray();
        Array.Reverse(stringArray);
        string passwordAsReversedUserName = new string(stringArray);
        int attemps = 4;
        while (attemps>0)
        {
            attemps--;
            string typedPass = Console.ReadLine();
            if (passwordAsReversedUserName == typedPass)
            {
                Console.WriteLine($"User {userName} logged in."); break;
            }
            else
            {
                if (attemps==0)
                {
                    Console.WriteLine($"User {userName} blocked!");
                }
                else
                {
                    {
                        Console.WriteLine($"Incorrect password. Try again.");
                    }
                }
            }
        }
    }
}

