using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeCatCodingKoce
{
    class DeCatCoding
    {
        // 1. read input
        // 1.1 extract all cat numbers from the input
        // 2. convert all cat numbers to decimal
        // 3. convert all decimal numbers to base 26
        // 4. join by space and print

        static ulong CatToDec(string catNumber)
        {
            ulong result = 0;

            foreach (char digit in catNumber)
            {
                result = (ulong)(digit - 'a') + result * 21;    
            } 

            return result;
        }

        static string DecTo26(ulong dec)
        {
            string result = string.Empty;

            do
            {
                char digitValue = (char)('a' + (dec % 26));
                result = digitValue + result;
                dec /= 26;
            }
            while (dec > 0);

            return result;
        }

        static void Main()
        {
            string[] numbers = Console.ReadLine()
                .Split(' ')
                .Select(CatToDec)
                .Select(DecTo26)
                .ToArray();

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
