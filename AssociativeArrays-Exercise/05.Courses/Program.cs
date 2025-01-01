using System.Xml.Linq;

namespace _05.Courses
{

    /*
      Print the information about each course in the following the format: "{courseName}: {registeredStudents}"

· Print the information about each student in the following the format: "-- {studentName}"
     
     */
    class Courses
    {
        public string CourseName { get; set; }
        public List<string> StudentNames { get; set; }

        public Courses(string courseName)
        {
            CourseName = courseName;
            StudentNames = new List<string>();
        }
        public override string ToString()
        {
            string result = $"{CourseName}: {StudentNames.Count}\n";
            for (int i = 0; i < StudentNames.Count; i++)
            {
                result+= $"-- {StudentNames[i]}\n";
            }
            return result.Trim();
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {

            Dictionary<string, Courses> allCoursesInfo = new Dictionary<string, Courses>();
            string input = string.Empty;
            while ((input = Console.ReadLine()) != "end")
            {
                string[] arguments = input.Split(" : ");
                string courseName = arguments[0];
                string studentName = arguments[1];

                if (!allCoursesInfo.ContainsKey(courseName))
                {
                    Courses course = new Courses(courseName);
                    allCoursesInfo.Add(courseName, course);
                }
                allCoursesInfo[courseName].StudentNames.Add(studentName);

            }

            foreach (Courses course in allCoursesInfo.Values)
            {
                Console.WriteLine(course.ToString());
            }
        }
    }
}
