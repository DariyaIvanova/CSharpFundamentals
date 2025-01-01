
/*
 2 1 1 2 3 3 2 2 2 1
 */
internal class Program
{
    static void Main()
    {
        string[] symbols = Console.ReadLine().Split();
        int bestCount = 0;
        string bestCountSymbol = "";

        for (int i = symbols.Length-1; i >=0; i--)
        {
            int currentCount = 1;
            for (int j = i-1; j >=0; j--)
            {
                if (symbols[i] == symbols[j])
                {
                    currentCount++;
                    if (bestCount <= currentCount)
                    {
                        bestCount = currentCount;
                        bestCountSymbol = symbols[i];
                    }
                }
                else
                {
                    i = j+1;
                    break; 
                } 
            }
        }
        for (int i = 0; i < bestCount; i++)
        {
            Console.Write($"{bestCountSymbol} ");
        }
    }

   
}

