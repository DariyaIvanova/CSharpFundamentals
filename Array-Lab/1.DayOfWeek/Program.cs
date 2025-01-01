using System.Globalization;

internal class Program
{
    static void Main()
    {

        string[] daysOfWeek = {"Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday"};
        int inputNumber = int.Parse(Console.ReadLine());

        if (inputNumber < 1 || inputNumber > 7)
        {
            Console.WriteLine("Invalid day!");
        }
        else 
        {
            Console.WriteLine(daysOfWeek[inputNumber-1]);
        }
        
    }
}

