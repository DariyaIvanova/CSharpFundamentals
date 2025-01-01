
/*
    • coffee – 1.50
    • water – 1.00
    • coke – 1.40
    • snacks – 2.00
 */
using System;

namespace _05.Orders
{
    internal class Program
    {
        static void Main()
        {
            

            string drinkType = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());

            OrderCalculation(drinkType, quantity);

        }

        static void OrderCalculation(string drinkType, int quantity)
        {
            double totalOrder;
            const double coffeePrice = 1.50;
            const double waterPrice = 1.00;
            const double cokePrice = 1.40;
            const double snacksPrice = 2.00;

            switch (drinkType)
            {
                case "coffee":
                    totalOrder = coffeePrice * quantity;
                    Console.WriteLine($"{totalOrder:f2}"); break;
                case "water":
                    totalOrder = waterPrice * quantity;
                    Console.WriteLine($"{totalOrder:f2}"); break;
                case "coke":
                    totalOrder = cokePrice * quantity;
                    Console.WriteLine($"{totalOrder:f2}"); break;
                case "snacks":
                    totalOrder = snacksPrice * quantity;
                    Console.WriteLine($"{totalOrder:f2}"); break;

            }
        }
    }
}
