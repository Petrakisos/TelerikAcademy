namespace CalculationProblemKoce
{
    using System;
    using System.Linq;

    class CalculationProblem
    {

        // 1. read input
        // 2. convert every number to it's decimal value
        // 3. sum all the numbers
        // 4. convert the sum to meow numeral system
        // 5. print the result

        static int NtoDec(string n)
        {
            int result = 0;

            byte NumeralBase = 23;

            foreach (char letter in n)
            {
                result = (letter - 'a') + result * NumeralBase;
            }

            return result;
        }

        static string DecToN(int dec)
        {
            string result = string.Empty;

            byte NumeralBase = 23;

            do
            {
                char letter = (char)('a' + (dec % NumeralBase));
                result = letter + result;
                dec /= NumeralBase;

            } while (dec > 0);

            return result;
        }

        static void Main()
        {

            int sum = Console.ReadLine().Split(' ').Select(NtoDec).Sum();

            string answer = DecToN(sum) + " = " + sum;

            Console.WriteLine(answer);
        }
    }
}
