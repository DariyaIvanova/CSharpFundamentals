namespace _9.KaminoFactory_Resolved
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sequenceLength = int.Parse(Console.ReadLine());
            int[] DNA = new int[sequenceLength];
            int DNAsum = 0;
            int DNAcount = -1;
            int DNAStartIndex = -1;
            int DNASample = 0;

            int sample = 0;

            string input = "";
            while ((input = Console.ReadLine()) != "Clone them!")
            {
                //----------------------------- CURRENT DNA INFO -----------------------------
                sample++;
                int[] currentDNA = input.Split("!", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                int currCount = 0;
                int currDNASum = 0;
                int currStartIndex = 0;
                int currEndIndex = 0;
                bool isBetterDna = false;


                int count = 0;
                for (int i = 0; i < currentDNA.Length; i++)
                {
                    if (currentDNA[i] != 1)
                    {
                        count = 0;
                        continue;
                    }
                    count++;
                    if (count > currCount)
                    {
                        currCount = count;
                        currEndIndex = i;
                    }
                }

                currStartIndex = currEndIndex - currCount + 1;
                currDNASum = currentDNA.Sum();

                //-------------------- CHECK CURRENT DNA WITH BEST DNA -----------------------

                if (currCount > DNAcount)
                {
                    isBetterDna = true;
                }
                else if (currCount == DNAcount)
                {
                    if (currStartIndex < DNAStartIndex)
                    {
                        isBetterDna = true;
                    }
                    else if (currStartIndex == DNAStartIndex)
                    {
                        if (currDNASum > DNAsum)
                        {
                            isBetterDna = true;
                        }
                    }
                }
                if (isBetterDna)
                {
                    DNA = currentDNA;
                    DNAcount = currCount;
                    DNAStartIndex = currStartIndex;
                    DNAsum = currDNASum;
                    DNASample = sample;
                }

            }
            Console.WriteLine($"Best DNA sample {DNASample} with sum: {DNAsum}.");
            Console.WriteLine(String.Join(" ", DNA));
        }
    }
}
