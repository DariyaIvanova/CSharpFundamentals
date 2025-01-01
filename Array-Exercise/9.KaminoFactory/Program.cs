using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;


/*
5
1!0!1!1!0
0!1!1!0!0
Clone them!


4
1!1!0!1
1!0!0!1
1!1!0!0
Clone them!

5
1!0!1!1!0!!!1!!1!0!!!!!!1
0!1!1!0!0
Clone them!
 */
internal class Program
{
    static void Main()
    {
        int dnaLength = int.Parse(Console.ReadLine());

        string input = "";
        int bestSequenceIndex = 1;
        int bestSequenceSum = 1;
        int currentSequenceIndex = 0;
        int[] bestDnaSample = new int[dnaLength];
        int bestStartIndex = dnaLength - 1;
        int bestSum = 0;


        while ((input = Console.ReadLine()) != "Clone them!")
        {

            int[] currentArr = SplittedArray(input);

            int currentSequenceSum = 1;
            currentSequenceIndex++;

            for (int i = currentArr.Length - 1; i > 0; i--)
            {
                int currentBestStartIndex;
                if (currentArr[i] == 1 && currentArr[i - 1] == 1)
                {
                    currentSequenceSum++;
                    currentBestStartIndex = i - 1;
                    if (currentSequenceSum >= bestSequenceSum)
                    {
                        if ((currentSequenceSum == bestSequenceSum)&&(bestStartIndex == currentBestStartIndex))
                        {
                            if (BestSum(currentArr)>bestSum)
                            {
                                bestSum = BestSum(currentArr);
                            }
                            

                            bestSequenceSum = currentSequenceSum;
                            bestSequenceIndex = currentSequenceIndex;
                            bestStartIndex = currentBestStartIndex;
                        }
                        else
                        {
                            bestSequenceSum = currentSequenceSum;
                            bestSequenceIndex = currentSequenceIndex;
                            bestStartIndex = currentBestStartIndex;
                            bestSum = currentArr.Where(x => x != 0).Sum();
                        }
                       
                    }
                    else if (currentSequenceSum == bestSequenceSum)
                    {
                        if (bestStartIndex == currentBestStartIndex)
                        {
                            bestSequenceSum = currentArr.Where(x => x != 0).Sum();
                            bestSequenceIndex = currentSequenceIndex;
                            bestStartIndex = currentBestStartIndex;
                        }
                        else
                        {
                            bestSequenceSum = currentSequenceSum;
                        }
                    }
      
                }
                else
                {
                    currentSequenceSum = 1;
                }
            }
        }
        Console.WriteLine($"Best DNA sample {bestSequenceIndex} with sum: {bestSequenceSum}.");
        //Console.WriteLine(bestSequenceSum);





    }

    static int[]  SplittedArray(string input)
    {
        string[] array = input.Split("!").ToArray();
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = array[i].Replace("!", string.Empty);
        }
        array = array.Where(x => !string.IsNullOrEmpty(x)).ToArray();
        int[] intArray = array.Select(int.Parse).ToArray();
        return intArray;
    }
    static int BestSum(int[] array)
    {
        int result=array.Where(x => x != 0).Sum();
        return result;  
    }
}

