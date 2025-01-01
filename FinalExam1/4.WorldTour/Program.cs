


namespace _4.WorldTour
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string allStops = Console.ReadLine();

            string input = string.Empty;

            while ((input=Console.ReadLine())!="Travel")
            {
                string[] commands=input.Split(":").ToArray();

                string command=commands[0];

                switch (command)
                {
                    case "Add Stop":
                        int index=int.Parse(commands[1]);
                        string insertedString = commands[2];
                        allStops = AddStop(allStops, index, insertedString);
                        Console.WriteLine(allStops);
                        break;

                    case "Remove Stop":
                        int startIndex=int.Parse(commands[1]);
                        int endIndex=int.Parse(commands[2]);
                        allStops = RemoveStop(allStops, startIndex, endIndex);
                        Console.WriteLine(allStops);
                        break;

                    case "Switch":
                        string oldString=commands[1];
                        string newString=commands[2];
                        allStops = SwitchStrings(allStops, oldString, newString);
                        Console.WriteLine(allStops);
                        break;


                }
            }
            Console.WriteLine($"Ready for world tour! Planned stops: {allStops}");
        }
        public static bool CheckIndexBoundery(int index, string allStops)
        {
            if (!(index < 0 || index > allStops.Length - 1))
            {
                return true;
            }
            return false;
        }
        public static string SwitchStrings(string allStops, string oldString, string newString)
        {
            if (allStops.Contains(oldString))
            { 
                allStops=allStops.Replace(oldString, newString);
            }
            
            return allStops;
        }

        public static string RemoveStop(string allStops, int startIndex, int endIndex)
        {
            if (CheckIndexBoundery(startIndex, allStops)&&CheckIndexBoundery(endIndex, allStops))
            {
                allStops = allStops.Remove(startIndex, endIndex - startIndex + 1);

               
            }
            
            return allStops;
        }

        public static string AddStop(string allStops, int index, string insertedString)
        {
            if (CheckIndexBoundery(index, allStops))
            {
                allStops=allStops.Insert(index, insertedString);
            }
    
            return allStops;
        }
    }
}
