using System.ComponentModel.DataAnnotations;

internal class Program
{
    static void Main(string[] args)
    {
        int countInputs = int.Parse(Console.ReadLine());
        char[] vowels = {'A', 'a', 'E', 'e', 'U', 'u', 'I', 'i', 'O', 'o' };
        

        int[] finalSums = new int[countInputs];

        for (int i = 0; i < countInputs; i++)
        {
            string currInput = Console.ReadLine();
            int stringLength = currInput.Length;
            int finalSum = 0;

            for (int j = 0; j < currInput.Length; j++)
            {
                if (vowels.Contains(currInput[j]))
                {
                    finalSum += (int)currInput[j] * stringLength;
                }
                else 
                {
                    finalSum += (int)currInput[j] / stringLength;
                }
            }
            finalSums[i]= finalSum;

        }
        Array.Sort(finalSums);
        for (int i = 0; i < countInputs; i++)
        {
            Console.WriteLine(finalSums[i]);
        }
    }
}
