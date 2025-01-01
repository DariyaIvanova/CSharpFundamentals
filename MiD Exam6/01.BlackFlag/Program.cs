namespace _01.BlackFlag
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int daysPlunder = int.Parse(Console.ReadLine());
            int dailyPlunder = int.Parse(Console.ReadLine());
            double expectedPlunder = double.Parse(Console.ReadLine());


            double totalPlunder = 0.0;


            for (int i = 1; i <= daysPlunder; i++)
            {
                totalPlunder += dailyPlunder;

                if (i % 3 == 0)
                {
                    totalPlunder += dailyPlunder * 0.5;
                }
                if (i % 5 == 0)
                {

                    totalPlunder = totalPlunder - totalPlunder * 30 / 100;
                }

            }
            if (totalPlunder >= expectedPlunder)
            {
                Console.WriteLine($"Ahoy! {totalPlunder:f2} plunder gained.");
                return;
            }
            double percentage = totalPlunder / expectedPlunder * 100;
            Console.WriteLine($"Collected only {percentage:f2}% of the plunder.");
        }
    }
}
