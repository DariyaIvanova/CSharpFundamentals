internal class Program
{
    static void Main()
    {
        string dayType = Console.ReadLine();
        int age = int.Parse(Console.ReadLine());

        int price = 0;

        if (dayType=="Weekday")
        {
            if (age >= 0 && age <= 18) price = 12;
            else if (age>18 && age <= 64) price = 18;
            else if (age>64 && age <= 122) price = 12;
            else price = 0;

        }
        else if (dayType == "Weekend")
        {
            if (age >= 0 && age <= 18) price = 15;
            else if (age > 18 && age <= 64) price = 20;
            else if (age > 64 && age <= 122) price = 15;
            else price = 0;
        }
        else if (dayType == "Holiday")
        {
            if (age >= 0 && age <= 18) price = 5;
            else if (age > 18 && age <= 64) price = 12;
            else if (age > 64 && age <= 122) price = 10;
            else price = 0;
        }
        if (price!=0)
        {
            Console.WriteLine($"{price}$");
        }else Console.WriteLine("Error!");

    }
}

