namespace _01.ComputerStore
{
    internal class Program
    {
        static void Main(string[] args)
        {
           string input=Console.ReadLine();
            decimal totalAmount = 0.0m;

            while (input!= "special" && input != "regular")
            {
                decimal currentAmount = decimal.Parse(input);
                if (currentAmount<= 0)
                {
                    Console.WriteLine("Invalid price!");
                    input = Console.ReadLine();
                    continue;
                }
                totalAmount += currentAmount;
                input = Console.ReadLine();
            }
            if (totalAmount==0.0m)
            {
                Console.WriteLine("Invalid order!");
                return;
            }
            decimal totalTaxes = totalAmount * 0.20m;
            decimal finalAmount = totalAmount + totalTaxes;
            switch (input)
            {
                case "special":
                    finalAmount = finalAmount * 0.90m;
                    break;
              
            }

            Console.WriteLine($"Congratulations you've just bought a new computer!\r\nPrice without taxes: {totalAmount:f2}$\r\nTaxes: {totalTaxes:f2}$\r\n-----------\r\nTotal price: {finalAmount:f2}$");
        }
    }
}
