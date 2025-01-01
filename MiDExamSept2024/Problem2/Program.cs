namespace Problem2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> initialWeaponName = Console.ReadLine().Split("|").ToList();

            string input = string.Empty;
            while ((input=Console.ReadLine())!="Done")
            {
                List<string> commands = input.Split().ToList();
                string command = commands[0];
               
                
                switch (command)
                {
                    case "Add":
                        string particle = commands[1];
                        int index = int.Parse(commands[2]);

                        if (CheckIndexBoundery(initialWeaponName, index))
                        {
                            initialWeaponName.Insert(index, particle);
                        }
                        break;

                    case "Remove":
                        int indexToBeRemoved = int.Parse(commands[1]);
                        if (CheckIndexBoundery(initialWeaponName, indexToBeRemoved))
                        {
                            initialWeaponName.RemoveAt(indexToBeRemoved);
                        }
                        break;

                    case "Check":
                        string evenOrOdd = commands[1];
                        if (evenOrOdd=="Even")
                        {
                            for (int i = 0; i < initialWeaponName.Count; i++)
                            {
                                if (i%2==0)
                                {
                                    Console.Write($"{initialWeaponName[i]} ");
                                    
                                }                               
                            }
                            Console.WriteLine();
                        }
                        else if (evenOrOdd == "Odd")
                        {
                            for (int i = 0; i < initialWeaponName.Count; i ++)
                            {
                                if (i%2!=0)
                                {
                                    Console.Write($"{initialWeaponName[i]} ");
                                   
                                }
                                
                            }
                            Console.WriteLine();
                        }
                        break;                  
                }
            }
            Console.WriteLine($"You crafted {string.Join("", initialWeaponName)}!");
        }

        static bool CheckIndexBoundery(List<string> weaponName, int index)
        {
            if (index<0 || index> weaponName.Count-1)
            {
                return false;
            }
            return true;
        }
    }
}
