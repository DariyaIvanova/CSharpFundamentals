internal class Program
{
    //The volume of a pyramid is found using the formula V = (1/3) Bh, where 'B' is the base area and 'h' is the height of the pyramid.
    static void Main()
    {
        Console.Write("Length: ");
        double length = double.Parse(Console.ReadLine());
        Console.Write("Width: ");
        double width = double.Parse(Console.ReadLine());
        Console.Write("Height: ");
        double height=double.Parse(Console.ReadLine());
        
        double volume = (length*width*height) / 3;
        Console.WriteLine($"Pyramid Volume: {volume:f2}");
    }
}

