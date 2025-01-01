namespace _04.Students
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> allStudents = new();

            string input = string.Empty;
            while (((input=Console.ReadLine())!="end"))
            {
                string[] studentsArguments = input.Split().ToArray();
                Student currentStudent = new(studentsArguments[0], studentsArguments[1], int.Parse(studentsArguments[2]), studentsArguments[3]);
                allStudents.Add(currentStudent);
            }
            string cityName = Console.ReadLine();
            foreach (Student student in allStudents)
            {
                if (student.HomeTown==cityName)
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
