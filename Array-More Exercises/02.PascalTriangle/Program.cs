internal class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine(1);
        int[] initialArray = { 1, 1 };
        if (n > 1)
        { 
            Console.WriteLine(string.Join(" ", initialArray));
        }
        for (int i = 2; i < n; i++)
        {
            
        
           int[] currentArray= new int[i+1];
            
            currentArray[0] = 1;
            currentArray[currentArray.Length-1] = 1;

            for (int k = 0; k < initialArray.Length-1; k++)
            {
                for (int j = 1; j < currentArray.Length - 1; j++)
                {

                    currentArray[j] = initialArray[j] + initialArray[j-1];
                }

            }
            Console.WriteLine(string.Join(" ", currentArray));
            
            
            int[] copyCurrentArray=new int[currentArray.Length];
            for (int p = 0; p < currentArray.Length; p++)
            {
                copyCurrentArray[p] = currentArray[p];
            }
            initialArray = copyCurrentArray;

        }
    }
    
}

