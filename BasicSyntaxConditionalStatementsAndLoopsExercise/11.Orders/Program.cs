internal class Program
{

    /*
On the first line, you will receive integer N – the count of orders the shop will receive.
-For each order you will receive the following information:
-Price per capsule – floating-point number in the range [0.00…1000.00].
-Days – integer in the range [1…31].
-Capsules count – integer in the range [0…2000]. 
     */
    static void Main()
    {
        int ordersCount = int.Parse(Console.ReadLine());
        decimal totalPrice = 0;


        for (int i = 0; i < ordersCount; i++)
        {
            decimal coffeePrice = 0;
            decimal pricePerCapsule = decimal.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());
            int capsuleCount = int.Parse(Console.ReadLine());

            coffeePrice = days * capsuleCount * pricePerCapsule;
            Console.WriteLine($"The price for the coffee is: ${coffeePrice:f2}");
            totalPrice += coffeePrice;
        }
        Console.WriteLine($"Total: ${totalPrice:f2}");





    }
}

