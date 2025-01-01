using System.Linq.Expressions;

internal class Program
{
    static void Main()
    {
        int count = int.Parse(Console.ReadLine());
        string groupType = Console.ReadLine();
        string dayOfWeek = Console.ReadLine();

        decimal price = 0;
        decimal pricePerPerson = 0;



        switch (groupType)
        {
            case "Students":

                switch (dayOfWeek)
                {
                    case "Friday":
                        pricePerPerson = 8.45m;
                        break;
                    case "Saturday":
                        pricePerPerson = 9.80m;
                        break;
                    case "Sunday":
                        pricePerPerson = 10.46m;
                        break;
                }
                price = pricePerPerson * count;
                if (count >= 30)
                {
                    price = price - (price * 15 / 100);
                }
                break;
            case "Business":
                switch (dayOfWeek)
                {
                    case "Friday":
                        pricePerPerson = 10.90m;
                        break;
                    case "Saturday":
                        pricePerPerson = 15.60m;
                        break;
                    case "Sunday":
                        pricePerPerson = 16m;
                        break;
                }

                if (count >= 100)
                {

                    count -= 10;
                }
                price = pricePerPerson * count; break;

            case "Regular":
                switch (dayOfWeek)
                {
                    case "Friday":
                        pricePerPerson = 15m;
                        break;
                    case "Saturday":
                        pricePerPerson = 20m;
                        break;
                    case "Sunday":
                        pricePerPerson = 22.50m;
                        break;
                }
                price = pricePerPerson * count;
                if (count >= 10 && count <= 20)
                {
                    price = price - (price * 5 / 100);
                }break;
        }
        
        Console.WriteLine($"Total price: {price:f2}");
    }
}

