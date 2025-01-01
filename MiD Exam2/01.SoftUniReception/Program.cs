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
            int studentsCount = int.Parse(Console.ReadLine());
            if (studentsCount == 0)
            {
                Console.WriteLine($"Time needed: 0h.");
                return;
            }

            int housrWithoutBreak = studentsCount / efficiencyPerHour;
            int breaksCount = 0;
            if (studentsCount % efficiencyPerHour == 0)
            {
                if (housrWithoutBreak % 3 == 0)
                {
                    breaksCount = (housrWithoutBreak / 3) - 1;
                }
                else
                {
                    breaksCount = housrWithoutBreak / 3;
                }


            }
            else
            {
                breaksCount = housrWithoutBreak / 3;
                housrWithoutBreak += 1;
            }


            int hoursWithBreak = housrWithoutBreak + breaksCount;

            Console.WriteLine($"Time needed: {hoursWithBreak}h.");
        }
    }
}
