namespace _01.SoftUniReception
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int efficiencyPerHour = 0;
            for (int i = 0; i < 3; i++)
            {
                efficiencyPerHour += int.Parse(Console.ReadLine());
            }
            int studentsCount=int.Parse(Console.ReadLine());

            int housrWithoutBreak = studentsCount / efficiencyPerHour;
            int breaksCount = housrWithoutBreak / 3;
            if (studentsCount % efficiencyPerHour!=0)
            {
                housrWithoutBreak += 1;
            }
            int hoursWithBreak = housrWithoutBreak + breaksCount;

            Console.WriteLine($"Time needed: {hoursWithBreak}h.");

        }
    }
}
