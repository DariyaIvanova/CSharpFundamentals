namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            List<Student> students = new List<Student>();

            for (int i = 0; i < n; i++)
            {
                Student student = ReadStudent();
                PrintStudent(student);
            }
            

            void PrintStudent(Student student)
            {
                Console.WriteLine($"{student.Name} - {student.Age} -> {student.Score}");
            }

             Student ReadStudent()
            {
                Student student = new Student();
                Console.WriteLine("What is your name:");
                student.Name = Console.ReadLine();

                Console.WriteLine("What is your age:");
                student.Age = int.Parse(Console.ReadLine());

                Console.WriteLine("What is your score:");
                student.Score = double.Parse(Console.ReadLine());

                return student;
            }
        }
        
    }
    class Student 
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public double Score { get; set; }
    }
}
