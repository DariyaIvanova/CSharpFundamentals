using System;

namespace _04.PasswordValidator
{
    internal class Program
    {
        static void Main()
        {
            string password = Console.ReadLine();
            if (!CheckPasswordLength(password))
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
            }
            if (!CheckOnlyLettersAndDigits(password))
            {
                Console.WriteLine("Password must consist only of letters and digits");
            }
            if (!(CheckForTwoDigitsMin(password)))
            {
                Console.WriteLine("Password must have at least 2 digits");
            }

            if (CheckPasswordLength(password)&& CheckOnlyLettersAndDigits(password)&& CheckForTwoDigitsMin(password))
            {
                Console.WriteLine("Password is valid");
            }

        }
        static bool CheckPasswordLength(string pass)
        {            
            if (pass.Length < 6 || pass.Length > 10)
            {
               return false;
            }
            return true; 
        }
        static bool CheckOnlyLettersAndDigits(string pass)
        {
            for (int i = 0; i < pass.Length; i++)
            {
                if (!((pass[i]>=48 && pass[i]<=57)||(pass[i] >= 65 && pass[i] <=90)|| (pass[i] >= 97 && pass[i] <= 122)))
                {
                    return false;
                }              
            }
            return true;
        }
        static bool CheckForTwoDigitsMin(string pass)
        {
            int counter = 0;
            for (int i = 0; i < pass.Length; i++)
            {
                if ((pass[i] >= 48 && pass[i] <= 57))
                {
                    counter++;
                    if (counter>=2)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
