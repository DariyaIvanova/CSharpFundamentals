using System;
using System.Runtime.CompilerServices;

namespace _01.Ranking
{
    public class User
    {
        public string Name { get; }
        public Dictionary <string, int> ContestPoints { get; }

        public User(string name)
        {
            Name = name;
            ContestPoints = new Dictionary <string, int> ();
        }
    }
   
    
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> dictContestPassword= new Dictionary<string, string>();   
            Dictionary <string, User> dictStudents=new Dictionary<string, User> ();

            
            string input = string.Empty;

            while ((input=Console.ReadLine())!= "end of contests")
            {
                string[] arguments = input.Split(":");
                string contest=arguments[0];
                string contestPassword=arguments[1];
                if (!dictContestPassword.ContainsKey(contest))
                {
                    dictContestPassword.Add(contest, contestPassword);
                }
            }

            while ((input=Console.ReadLine())!= "end of submissions")
            {
                string[] arguments = input.Split("=>");
                string contest=arguments[0];
                string password=arguments[1];
                string username=arguments[2];
                int points = int.Parse(arguments[3]);

                if (!dictContestPassword.ContainsKey(contest)|| dictContestPassword[contest]!=password)
                {
                    continue;
                }
                if (!dictStudents.ContainsKey(username))
                {
                    dictStudents.Add(username, new User(username));
                }
                User student=dictStudents[username];

                if (!student.ContestPoints.ContainsKey(contest))
                {
                    student.ContestPoints.Add(contest, points);
                }
                if (student.ContestPoints[contest]<points)
                {
                    student.ContestPoints[contest] = points;
                }

            }

            PrintTheRanking(dictStudents.Values.ToList());

            
        }
        public static void PrintTheRanking(List<User> listWithUsers)
        {
            User bestCandidate = listWithUsers.OrderByDescending(st => st.ContestPoints.Values.Sum()).First();
            Console.WriteLine($"Best candidate is {bestCandidate.Name} with total {bestCandidate.ContestPoints.Values.Sum()} points.");
            Console.WriteLine("Ranking:");

            foreach (User student in listWithUsers.OrderBy(x=>x.Name))
            {
                Console.WriteLine(student.Name);
                foreach (var (contest, points) in student.ContestPoints.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"#  {contest} -> {points}");
                }
            }


        }
    }
}
