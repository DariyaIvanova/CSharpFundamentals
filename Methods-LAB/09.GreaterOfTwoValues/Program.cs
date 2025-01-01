
/*
int
2
16


char
a
z

string
aaa
bbb

 */
using System;

namespace _09.GreaterOfTwoValues
{
    internal class Program
    {
        static void Main()
        {
            string type=Console.ReadLine();
            switch (type)
            {
                case "int":
                    int num1 = int.Parse(Console.ReadLine());
                    int num2 = int.Parse(Console.ReadLine());
                    Console.WriteLine(GetMax(num1, num2));
                    break;
                case "char":
                    char firstChar = char.Parse(Console.ReadLine());
                    char secondChar = char.Parse(Console.ReadLine());
                    Console.WriteLine(GetMax(firstChar, secondChar));
                    break;
                case "string":
                    string firstString = Console.ReadLine();
                    string secondString = Console.ReadLine();
                    Console.WriteLine(GetMax(firstString, secondString));
                    break;
            }

        }

        static int GetMax(int num1, int num2)
        {
            int result=Math.Max(num1, num2);
            return result;
        }
        static char GetMax(char firstChar, char secondChar)
        {
            if (firstChar> secondChar)
            {
                return firstChar;
            }
            else
            {
                return secondChar;
            }
            
        }
        static string GetMax(string firstString, string secondString)
        {
            if (String.Compare(firstString, secondString)<0)
            {
                return secondString;
            }
            else
            {
                return firstString;
            }
        }
    }
}
