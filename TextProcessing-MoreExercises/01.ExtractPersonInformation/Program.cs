namespace _01.ExtractPersonInformation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                string input = Console.ReadLine();
                int indexNameStart = input.IndexOf('@');
                int indexNameEnd = input.IndexOf('|');

                int indexAgeStart = input.IndexOf('#');
                int indexAgeEnd = input.IndexOf('*');

                string name=input.Substring(indexNameStart+1, indexNameEnd-indexNameStart-1);
                string age = input.Substring(indexAgeStart+1,indexAgeEnd-indexAgeStart-1);
                Console.WriteLine($"{name} is {age} years old.");
            }
        }
    }
}
