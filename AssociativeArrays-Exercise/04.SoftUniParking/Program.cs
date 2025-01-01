using System.Threading.Channels;

namespace _04.SoftUniParking
{
    class User
    {
        public string UserName { get; set; }
        public string LicensePlateNumber { get; set; }

        public User(string userName,string licensePlateNumber)
        {
            UserName=userName;
            LicensePlateNumber=licensePlateNumber;

        }
        public override string ToString()
        {
            return $"{UserName} => {LicensePlateNumber}"; 
        }
    }
    
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            Dictionary<string, User> users = new Dictionary<string, User>();

            for (int i = 0; i < count; i++)
            {
                string input = Console.ReadLine();
                string[] arguments = input.Split();
                string command= arguments[0];
                string userName= arguments[1];

                switch (command)
                {
                    case "register":
                        string licensePlateNumber = arguments[2];
                        User user= new User(userName, licensePlateNumber);

                        if (!users.ContainsKey(userName))
                        {
                            users.Add(userName, user);
                            Console.WriteLine($"{userName} registered {licensePlateNumber} successfully");
                        }
                        else
                        {
                            Console.WriteLine($"ERROR: already registered with plate number {licensePlateNumber}");
                        }

                        break;

                    case "unregister":
                        if (!users.ContainsKey(userName))
                        {
                            Console.WriteLine($"ERROR: user {userName} not found");
                        }
                        else
                        {
                            users.Remove(userName);
                            Console.WriteLine($"{userName} unregistered successfully");
                        }
                        break;                  
                }
            }

            foreach (User user in users.Values)
            {
                Console.WriteLine(user.ToString());
            }
        }
    }
}
