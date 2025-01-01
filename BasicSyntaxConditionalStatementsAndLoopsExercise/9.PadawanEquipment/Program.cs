internal class Program
{
    /*
The amount of money John has – floating-point number in the range [0.00…1000.00].
The count of students – integer in the range [0…100].
The price of lightsabers for a single saber – floating-point number in the range [0.00…100.00].
The price of robes for a single robe – floating-point number in the range [0.00…100.00].
The price of belts for a single belt – floating-point number in the range [0.00…100.00].

Lightsabres sometimes break, so John should buy 10% more (taken from the students' count), rounded up to the next integer.
Every sixth belt is free.
     */
    static void Main()
    {
        decimal budget = decimal.Parse(Console.ReadLine());
        int countStudents = int.Parse(Console.ReadLine());
        decimal lightsaberPrice = decimal.Parse(Console.ReadLine());
        decimal robesPrice = decimal.Parse(Console.ReadLine());
        decimal beltsPrice = decimal.Parse(Console.ReadLine());

        double lightsabersQty = Math.Ceiling(countStudents * 1.1);
        int robesQty = countStudents - (countStudents / 6);
        decimal neededSum = lightsaberPrice * (decimal)lightsabersQty+ robesPrice*countStudents+ beltsPrice* robesQty;

        decimal diff = Math.Abs(neededSum-budget);
        if (neededSum <= budget)
        {
            Console.WriteLine($"The money is enough - it would cost {neededSum:f2}lv.");
        }
        else 
        {
            Console.WriteLine($"John will need {diff:f2}lv more.");
        }
    }
}

