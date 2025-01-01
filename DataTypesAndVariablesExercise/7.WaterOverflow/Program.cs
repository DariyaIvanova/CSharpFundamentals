internal class Program
{
    static void Main()
    {
        int capacity = 255;
        int pouredLiters = 0;

        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            int currentWater=int.Parse(Console.ReadLine());
            if (currentWater<=capacity)
            {
                capacity -= currentWater; pouredLiters += currentWater;
            }
            else 
            {
                Console.WriteLine("Insufficient capacity!");
            }
        }
        Console.WriteLine(pouredLiters);
    }
}

