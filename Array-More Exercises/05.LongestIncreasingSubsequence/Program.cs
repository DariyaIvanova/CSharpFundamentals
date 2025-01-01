internal class Program
{
    static void Main()
    {
        List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();
        List<int> maxElemenst = new List<int>();

        int maxCount = 1;


        for (int j = 0; j < nums.Count - 1; j++)
        {
            int currentFirstElement = nums[j];
            List<int> currentMaxElements = new List<int>();

            currentMaxElements.Add(currentFirstElement);


           
            
            List<int> currentList = nums.Skip(j + 1).Where(x => x > currentFirstElement).ToList();

            currentMaxElements.AddRange(currentList);

            int currentMaxCount = currentList.Count;

            if (currentMaxCount > maxCount)

            {
                maxCount = currentMaxCount;
                maxElemenst = currentMaxElements;

            }

           
        }
        Console.WriteLine(string.Join(" ", maxElemenst));

    }
    }

