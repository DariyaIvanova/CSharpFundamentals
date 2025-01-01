internal class Program
{
    static void Main()
    {
        string country = Console.ReadLine();
        string result = "";

        if (country == "England" || country == "USA")
        {
            result = "English";
        }
        else if (country == "Spain" || country == "Argentina" || country=="Mexico")
        {
            result = "Spanish";
        }
        else
        {
            result = "unknown";
        }
        Console.WriteLine(result);
    }
}

