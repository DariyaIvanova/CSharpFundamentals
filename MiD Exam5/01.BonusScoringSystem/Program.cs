
//{total bonus} = {student attendances} / {course lectures} * (5 + {additional bonus})

using System.Threading.Channels;

namespace _01.BonusScoringSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int  studentsCount=int.Parse(Console.ReadLine());
            int lecturesCount = int.Parse(Console.ReadLine());
            int additionalBonus=int.Parse(Console.ReadLine());
            double maxBonus = 0;
            int maxStudentAttendances = 0;

            for (int i = 0; i < studentsCount; i++)
            {
                int attendanceOfStudent = int.Parse(Console.ReadLine());
                double currentTotalBonus = CalculateTotalBonus(studentsCount, lecturesCount, additionalBonus, attendanceOfStudent);
                if (currentTotalBonus > maxBonus)
                {
                    maxBonus = currentTotalBonus;
                    maxStudentAttendances = attendanceOfStudent;
                }
            }
            Console.WriteLine($"Max Bonus: {Math.Round(maxBonus)}.");
            Console.WriteLine($"The student has attended {maxStudentAttendances} lectures.");
        }

        

        static double CalculateTotalBonus(int studentsCount, int lecturesCount, int additionalBonus, int attendanceOfStudent)
        {
            double totalBonus = (attendanceOfStudent*1.0 / lecturesCount) * (5+additionalBonus);
            return totalBonus;
        }
    }
}
