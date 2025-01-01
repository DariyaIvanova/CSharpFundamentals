using System.Text;

namespace _05.DigitsLettersAndOther
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            StringBuilder digitsOnly = new StringBuilder();
            StringBuilder lettersOnly = new StringBuilder();
            StringBuilder otherSymbolsOnly = new StringBuilder();

            foreach (char chrr in input)
            {
                if (char.IsDigit(chrr))
                {
                    digitsOnly.Append(chrr);
                }
                else if (char.IsLetter(chrr))
                {
                    lettersOnly.Append(chrr);
                }
                else
                {
                    otherSymbolsOnly.Append(chrr);
                }
            }

            Console.WriteLine(digitsOnly);
            Console.WriteLine(lettersOnly);
            Console.WriteLine(otherSymbolsOnly);

            /*
             //Using LINQ

        //char[] digits = input
        //    .Where(ch => char.IsDigit(ch))
        //    .ToArray();

        //char[] letters = input
        //    .Where(ch => char.IsLetter(ch))
        //    .ToArray();

        //char[] others = input
        //    .Where(ch => !char.IsLetterOrDigit(ch))
        //    .ToArray(); 
           
             */


        }
    }
}
