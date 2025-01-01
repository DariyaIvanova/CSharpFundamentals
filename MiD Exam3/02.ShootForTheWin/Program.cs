

namespace _02.ShootForTheWin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();

            string target = string.Empty;
            int counter = 0;

            while ((target = Console.ReadLine()) != "End")
            {
                int currentIndex = int.Parse(target);


                if (!CheckIndexInBounderies(nums, currentIndex)|| nums[currentIndex] == -1)
                {
                    continue;
                }
                counter ++;
                nums = ManipulateTargets(nums, currentIndex);
            }
            Console.WriteLine($"Shot targets: {counter} -> {string.Join(" ", nums)}");
        }

        static List<int> ManipulateTargets(List<int> nums, int currentIndex)
        {
            int value = nums[currentIndex];
            

            nums[currentIndex] = -1;
            for (int i = 0; i < nums.Count; i++)
            {
                if (nums[i] != -1)
                {
                    if (nums[i] > value)
                    {
                        nums[i] -= value;
                        
                    }
                    else
                    {
                        nums[i] += value;
                        
                    }
                }
                else
                {
                    continue;
                }
                               
            }
            return nums;
        }

        static bool CheckIndexInBounderies(List<int> nums, int currentIndex)
        {
            if (currentIndex < 0 || currentIndex > nums.Count - 1)
            {
                return false;
            }
            return true;
        }
    }
}
