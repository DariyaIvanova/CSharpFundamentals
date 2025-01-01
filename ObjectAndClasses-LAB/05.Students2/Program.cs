namespace _05.Students2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> allStudents = new();

            string input = string.Empty;
            while (((input = Console.ReadLine()) != "end"))
            {
                string[] studentsArguments = input.Split().ToArray();
                Student currentStudent = allStudents.FirstOrDefault(s => s.FirstName == studentsArguments[0] && s.LastName ==studentsArguments[1]);

                if (currentStudent==null)
                {
                    allStudents.Add(new Student(studentsArguments[0], studentsArguments[1], int.Parse(studentsArguments[2]), studentsArguments[3]));
                }
                else
                {
                    currentStudent.FirstName = studentsArguments[0];
                    currentStudent.LastName = studentsArguments[1];
                    currentStudent.Age = int.Parse(studentsArguments[2]);
                    currentStudent.HomeTown = studentsArguments[3];

                }
            }
            string cityName = Console.ReadLine();
            foreach (Student student in allStudents)
            {
                if (student.HomeTown == cityName)
                {
                    Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
                }
            }
        }
    }
    public class Student
    {
        public Student(string firstName, string lastName, int age, string homeTown)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            HomeTown = homeTown;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string HomeTown { get; set; }
    }
}
