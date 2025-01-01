using System.Threading.Channels;

internal class Program
{
    static void Main()
    {
        int personsCount = int.Parse(Console.ReadLine());
        int capacity = int.Parse(Console.ReadLine());

        int result = (int)Math.Ceiling((double)personsCount/capacity) ;

       // result = personsCount / capacity + 1;
        Console.WriteLine(result);
    }
    
}

