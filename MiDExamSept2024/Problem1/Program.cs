namespace Problem1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double sizeOfSide = double.Parse(Console.ReadLine());
            double allArea = sizeOfSide * sizeOfSide * 6;

            double coveredArea = 0.0;

            int sheetsCount = int.Parse(Console.ReadLine());

            for (int i = 1; i <= sheetsCount; i++)
            {
                double currentLength = double.Parse(Console.ReadLine());
                double currentWidth = double.Parse(Console.ReadLine());

                double currentSheetArea = currentLength * currentWidth;
                if (i % 5 != 0)
                {
                    if (i % 3 == 0)
                    {
                        coveredArea += currentSheetArea * 0.75;
                    }
                    else
                    {
                        coveredArea += currentSheetArea;
                    }
                }                
            }
            if (coveredArea<allArea)
            {
                double percentageCovered = (coveredArea / allArea) * 100;
                double percentageUncovered = 100.00 - percentageCovered;
                Console.WriteLine($"You are out of paper!\r\n {percentageUncovered:f2}% of the box is not covered.");
            }
            else
            {
                double percentageCovered = (coveredArea - allArea) / coveredArea * 100;
                Console.WriteLine($"You've covered the gift box!\r\n {percentageCovered:f2}% wrap paper left.");
            }

        }
    }
}
