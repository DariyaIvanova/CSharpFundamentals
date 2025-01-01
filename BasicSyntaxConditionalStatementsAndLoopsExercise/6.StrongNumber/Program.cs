internal class Program
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        int factorielSum = 0;


        int num = number;
        while (num > 0)
        {
            int currentDigit = num % 10;
            int currentFactoriel = 1;
            for (int i = 2; i <=currentDigit ; i++)
            {
                currentFactoriel *= i;
            }
            factorielSum += currentFactoriel;
            num = num / 10;
        }
        //if (number == factorielSum)
        //{
        //    Console.WriteLine("yes");
        //}
        //else
        //{
        //    Console.WriteLine("no");

        //}

        string isStrongNumber = factorielSum==number ?"yes": "no";
        Console.WriteLine(isStrongNumber);

    }
}

