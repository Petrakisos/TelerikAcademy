using System;
using System.Collections.Generic;

class OneSystemToAnyOther
{
    static long ConvertHexadecimalToDecimal(string hexlValue, int inputBaseValue)
    {
        long sum = 0;

    //    int baseValue = 16;

        foreach (char value in hexlValue)
        {
            sum = hexDigits[value] + sum * inputBaseValue;
        }

        return sum;
    }

    static Dictionary<char, long> hexDigits = new Dictionary<char, long>()
        {
            {'0', 0  },
            {'1', 1  },
            {'2', 2  },
            {'3', 3  },
            {'4', 4  },
            {'5', 5  },
            {'6', 6  },
            {'7', 7  },
            {'8', 8  },
            {'9', 9  },
            {'A', 10 },
            {'B', 11 },
            {'C', 12 },
            {'D', 13 },
            {'E', 14 },
            {'F', 15 },
        };

    static string ConvertDecimalToHexadecimal(long decimalValue, int outputBaseValue)
    {
        string sum = "";

        string[] hexDigits = "0 1 2 3 4 5 6 7 8 9 A B C D E F".Split(' ');

      //  int baseValue = 16;

        do
        {
            long bit = decimalValue % outputBaseValue;
            sum = hexDigits[bit] + sum;
            decimalValue /= outputBaseValue;
        }
        while (decimalValue != 0);

        return sum;
    }
    static void Main()
    {
        int inputBaseValue = int.Parse(Console.ReadLine());

        string input = Console.ReadLine().ToUpper();

        int outputBaseValue = int.Parse(Console.ReadLine());

        Console.WriteLine(ConvertDecimalToHexadecimal(ConvertHexadecimalToDecimal(input, inputBaseValue), outputBaseValue));

    }
}
