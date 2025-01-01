namespace _07.CompanyUsers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary <string, List<string>> companiesDict = new Dictionary<string, List<string>>();
            string input = string.Empty;

            while ((input=Console.ReadLine())!="End")
            {
                string[] arguments = input.Split(" -> ");
                string companyName = arguments[0];
                string employeeId=arguments[1];

                if (!companiesDict.ContainsKey(companyName))
                {
                    companiesDict.Add(companyName, new List<string>());
                }
                if (!companiesDict[companyName].Contains(employeeId))
                {
                    companiesDict[companyName].Add(employeeId);
                }
            }

            foreach (var pair in companiesDict)
            {
                Console.WriteLine(pair.Key);
                foreach (string employeeId in pair.Value)
                {
                    Console.WriteLine($"-- {employeeId}");
                }
            }
        }
    }
}
