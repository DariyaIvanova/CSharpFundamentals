using System.Diagnostics.Metrics;

namespace _02.Judge
{
   public  class Contest
    {
        public string ContestName { get; set; }
        public Dictionary<string, int> UserAndPoints { get; set; }
        public Contest(string contestName)
        {
            ContestName = contestName;
            UserAndPoints = new Dictionary<string, int>();
        }
    }
    
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Contest> ContestIndividualStatistic = new Dictionary<string, Contest>();
            string input = string.Empty;

            while ((input=Console.ReadLine())!= "no more time")
            {
                string[] arguments = input.Split(" -> ");

                string userName=arguments[0];
                string contestName=arguments[1];
                int points=int.Parse(arguments[2]);

                if (!ContestIndividualStatistic.ContainsKey(contestName))
                {
                    ContestIndividualStatistic.Add(contestName, new Contest(contestName));
                    ContestIndividualStatistic[contestName].ContestName = contestName;
                                     
                }
                if (!ContestIndividualStatistic[contestName].UserAndPoints.ContainsKey(userName))
                {
                    ContestIndividualStatistic[contestName].UserAndPoints.Add(userName, points);
                }
                if (ContestIndividualStatistic[contestName].UserAndPoints.ContainsKey(userName))
                {
                                       
                    if (ContestIndividualStatistic[contestName].UserAndPoints[userName]<points)
                    {
                        ContestIndividualStatistic[contestName].UserAndPoints[userName] = points;
                    }
                }
            }
            int counter = 0;
            foreach (var contest in ContestIndividualStatistic)
            {
               
                Console.WriteLine($"{contest.Key}: {contest.Value.UserAndPoints.Keys.Count()} participants");
                foreach (var userPoints in contest.Value.UserAndPoints.OrderByDescending(x=>x.Value).ThenBy(y=>y.Key))
                {
                    Console.WriteLine($"{++counter}. {userPoints.Key} <::> {userPoints.Value}");
                   
                }
                counter = 0;
            }


            Dictionary<string, int> userAndPoints=new Dictionary<string, int>();
            counter = 0;
            foreach (var item in ContestIndividualStatistic)
            {
                foreach (var current in item.Value.UserAndPoints)
                {
                    if (!userAndPoints.ContainsKey(current.Key))
                    {
                        userAndPoints.Add(current.Key, 0);
                    }
                    userAndPoints[current.Key]+=current.Value;
                }
            }

            Console.WriteLine("Individual standings:");
            foreach (var item in userAndPoints.OrderByDescending(x=>x.Value))
            {
                Console.WriteLine($"{++counter}. {item.Key} -> {item.Value}");
              
            }


        }
    }
}
