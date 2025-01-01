internal class Program
{
    static void Main()
    {
        int fieldSize = int.Parse(Console.ReadLine());
        int[] initialIndexes = Console.ReadLine().Split().Select(int.Parse).ToArray(); //0, 1

        int[] field = new int[fieldSize];
        for (int i = 0; i < initialIndexes.Length; i++)
        {
            field[initialIndexes[i]] = 1;
        }
        //Console.WriteLine(string.Join(" ", field));
        string input = "";

        while ((input = Console.ReadLine()) != "end")
        {
            string[] commands = input.Split().ToArray();   //0 right 1
            int ladybugIndex = int.Parse(commands[0]);
            string direction = commands[1];
            int flyLength = int.Parse(commands[2]);

            if (field[ladybugIndex]==0 || ladybugIndex<0 || ladybugIndex>=fieldSize )
            {
                continue;
            }

            if (ladybugIndex >= 0 && ladybugIndex <= fieldSize - 1)
            {
                field[ladybugIndex] = 0;
                if (direction=="right")
                {
                    if ((ladybugIndex + flyLength) > fieldSize - 1)
                    {
                        continue;
                    }
                    for (int i = ladybugIndex + flyLength; i < fieldSize; i++)
                    {
                        if (field[i] != 1)
                        {
                            field[i] = 1;break;
                        }                      
                    }
                    
                    
                }
                else if (direction=="left")
                {
                    if ((ladybugIndex - flyLength) <0)
                    {
                        continue;
                    }

                    for (int i = ladybugIndex - flyLength; i >= 0; i--)
                    {
                        if (field[i] != 1)
                        {
                            field[i] = 1; break;
                        }
                    }                   
                }
            }
            else
            {
                continue;
            }

        }
        Console.WriteLine(string.Join(" ", field));
    }
}

