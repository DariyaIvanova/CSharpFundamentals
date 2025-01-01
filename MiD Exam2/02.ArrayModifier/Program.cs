


namespace _02.ArrayModifier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            string input=string.Empty;

            while ((input = Console.ReadLine())!="end")
            {
                string[] commands= input.Split().ToArray();  
                string command= commands[0];
                int firstIndex;
                int secondIndex;
                switch (command)
                {
                    case "swap":
                        firstIndex = int.Parse(commands[1]);
                        secondIndex = int.Parse(commands[2]);
                        numbers = SwapElement(numbers, firstIndex, secondIndex);
                        break;

                    case "multiply":
                        firstIndex = int.Parse(commands[1]);
                        secondIndex = int.Parse(commands[2]);
                        numbers = MultiplyElements(numbers, firstIndex, secondIndex);
                        break;

                    case "decrease":
                        numbers = DecreaseElements(numbers);
                        break;

                }
            }
            Console.WriteLine(string.Join(", ", numbers));
        }

        static List<int> DecreaseElements(List<int> numbers)
        {
            for (int i = 0; i < numbers.Count; i++)
            {
                numbers[i]--;
            }
            return numbers;
        }

        static List<int> MultiplyElements(List<int> numbers, int firstIndex, int secondIndex)
        {
            int secondElement = numbers[secondIndex];
            int firstElement = numbers[firstIndex];
            numbers[firstIndex] = firstElement * secondElement;
            return numbers;

        }

        static List<int> SwapElement(List<int> numbers, int firstIndex, int secondIndex)
        {
            int temp = numbers[firstIndex];
            numbers[firstIndex] = numbers[secondIndex];
            numbers[secondIndex] = temp; 

            return numbers;
        }
    }
}
