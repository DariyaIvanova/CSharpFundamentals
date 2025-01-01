



namespace _03.MovingTarget
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();

            string input = string.Empty;
            while ((input = Console.ReadLine()) != "End")
            {
                string[] commands = input.Split().ToArray();
                string command = commands[0];
                int index = int.Parse(commands[1]);


                switch (command)
                {
                    case "Shoot":
                        int power = int.Parse(commands[2]);
                        if (!CheckInOutBoundery(nums, index))
                        {
                            continue;
                        }
                        nums = ShootTarget(nums, index, power);
                        break;
                    case "Add":
                        int value = int.Parse(commands[2]);
                        if (CheckInOutBoundery(nums, index))
                        {
                            nums.Insert(index, value);
                        }
                        else
                        {
                            Console.WriteLine("Invalid placement!");
                        }
                        break;
                    case "Strike":
                        int radius = int.Parse(commands[2]);

                        int startIndex = index - radius;
                        int endIndex = index + radius;

                        if (!CheckInOutBoundery(nums, startIndex) || !CheckInOutBoundery(nums, endIndex))
                        {
                            Console.WriteLine("Strike missed!");
                            continue;
                        }
                        nums = StrikeTarget(nums, startIndex, endIndex);
                        break;

                }

            }
            Console.WriteLine(string.Join("|", nums));
        }

        static List<int> StrikeTarget(List<int> nums, int startIndex, int endIndex)
        {
            nums.RemoveRange(startIndex, endIndex - startIndex + 1);
            return nums;

        }

        static List<int> ShootTarget(List<int> nums, int index, int power)
        {
            if (nums[index] <= power)
            {
                nums.RemoveAt(index);
            }
            else
            {
                nums[index] -= power;
            }

            return nums;
        }

        static bool CheckInOutBoundery(List<int> nums, int index)
        {
            if (index < 0 || index > nums.Count - 1)
            {
                return false;
            }
            return true;
        }
    }
}
