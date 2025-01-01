
/*
 12521
 */

using System;

namespace _09.PalindromeIntegers
{
    internal class Program
    {
        static void Main()
        {
            string number="";
            while ((number =Console.ReadLine())!="END")
            {
                PalindromCheck(number);
            }

            
        }

        static void PalindromCheck(string number)
        {
            for (int i = 0; i < number.Length / 2; i++)
            {
                if (number[i] != number[number.Length - 1 - i])
                {
                    Console.WriteLine("false");
                    return;
                }               
            }
            Console.WriteLine("true");
        }
    }
}
