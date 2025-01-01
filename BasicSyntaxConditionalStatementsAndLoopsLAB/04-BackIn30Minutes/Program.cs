using System.Globalization;

internal class Program
{
    static void Main(string[] args)
    {
        int hour = int.Parse(Console.ReadLine());
        int minutes = int.Parse(Console.ReadLine());
        string timeToString = hour + ":" + minutes;
        DateTime timeToDateTime = DateTime.ParseExact(timeToString, "Hh:mm", CultureInfo.InvariantCulture);
        timeToDateTime = timeToDateTime.AddMinutes(30);
        
        Console.WriteLine($"{timeToDateTime.Hour}:{timeToDateTime.Minute}");


    }
}

