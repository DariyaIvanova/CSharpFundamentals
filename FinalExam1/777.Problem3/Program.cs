namespace _777.Problem3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int capacity = int.Parse(Console.ReadLine());
            Dictionary<string, User> allUsers = new Dictionary<string, User>();



            string input=string.Empty;

            while ((input=Console.ReadLine())!="Statistics")
            {
                string[] commands = input.Split("=").ToArray();
                string command=commands[0];

                switch (command)
                {
                    case "Add":
                        string username=commands[1];
                        int sentMessages=int.Parse(commands[2]);
                        int receivedMessages = int.Parse(commands[3]);

                        if (!allUsers.ContainsKey(username))
                        {
                            allUsers[username] = new User(username, sentMessages, receivedMessages);
                        }
                        break;
                    case "Message":
                        string sender=commands[1];
                        string receiver=commands[2];
                        if (allUsers.ContainsKey(sender)&&allUsers.ContainsKey(receiver))
                        {
                            allUsers[sender].Sent += 1;
                            allUsers[receiver].Received += 1;


                            int currentcapacitySender = allUsers[sender].CurrentCapacity(allUsers[sender].Sent, allUsers[sender].Received);
                            if (currentcapacitySender >= capacity)
                            {
                                allUsers.Remove(sender);
                                Console.WriteLine($"{sender} reached the capacity!");
                            }
                            
                            int currentcapacityReceiver = allUsers[receiver].CurrentCapacity(allUsers[receiver].Sent, allUsers[receiver].Received);
                            if (currentcapacityReceiver >= capacity)
                            {
                                allUsers.Remove(receiver);
                                Console.WriteLine($"{receiver} reached the capacity!");
                            }
                        }
                        break;
                    case "Empty":
                        string usernameToBeDeleted=commands[1];
                        if (usernameToBeDeleted=="All")
                        {
                            allUsers.Clear();
                        }
                        else
                        {
                            allUsers.Remove(usernameToBeDeleted);
                        }
                        break;
                }
            }

            Console.WriteLine($"Users count: {allUsers.Count}");
            foreach (User user in allUsers.Values)
            {
                Console.WriteLine($"{user.UserName} - {user.Sent+user.Received}");
            }
        }
    }

    public class User
    {
        public User(string userName, int sent, int received)
        {
            UserName = userName;
            Sent = sent;
            Received = received;
        }
        public int CurrentCapacity(int sent, int recieved)
        {
            return sent + recieved;
        }

        public string UserName { get; set; }
        public int Sent { get; set; }
        public int Received { get; set; }
    }
}
