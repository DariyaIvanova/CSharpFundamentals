﻿
namespace _05.MultiplyBigNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string bigNumber = Console.ReadLine();
            string multiplyNumber = Console.ReadLine();


            string result = Multiply(bigNumber, multiplyNumber);
            Console.WriteLine(result);
        }

        private static string Multiply(string bigNumber, string multiplyNumber)
        {
            if (bigNumber == "0" || multiplyNumber == "0")
            {
                return "0";
            }
            int carry = 0;
            int multiplier = int.Parse(multiplyNumber);

            char[] resultChars = new char[bigNumber.Length + 1];


            for (int i = bigNumber.Length - 1; i >= 0; i--)
            {
                int digit = int.Parse(bigNumber[i].ToString());
                int product = digit * multiplier + carry;
                resultChars[i + 1] = (char)(product % 10 + '0');
                carry = product / 10;
            }

            string result = string.Empty;

            if (carry > 0)
            {
                resultChars[0] = (char)(carry + '0');
                result = new string(resultChars);
            }
            else if (carry == 0)
            {
                result= new string(resultChars).Trim('\0');
            }
            return result;
        }
    }
}
