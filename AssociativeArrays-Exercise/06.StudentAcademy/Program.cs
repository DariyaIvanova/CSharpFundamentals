using System.Xml.Linq;

namespace _06.StudentAcademy
{
    public class Student
    {

        public Student(string studentName)
        {
            Name = studentName;
            Grades = new List<double>();
        }

        public string Name { get; set; }
        public List<double> Grades { get; set; }

        public override string ToString()
        {
            return $"{Name} -> {Grades.Average():f2}";
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            int countGrades = int.Parse(Console.ReadLine());
            Dictionary<string, Student> studentDictionary = new Dictionary<string, Student>();

            for (int i = 0; i < countGrades; i++)
            {

                string studentName = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());


                if (!studentDictionary.ContainsKey(studentName))
                {

                    studentDictionary.Add(studentName, new Student(studentName));
                    
                }
                studentDictionary[studentName].Grades.Add(grade);
              
            }

            var filteredStudents = studentDictionary.Where(pair => pair.Value.Grades.Average() >= 4.50);
            foreach (var studentPair in filteredStudents)
            {
                Console.WriteLine(studentPair.Value.ToString());
            }
        }
    }
}
