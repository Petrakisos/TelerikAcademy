using System;
using System.Collections.Generic;

class HexadecimalToBinary
{
    static void Main()
    {
        string hexValue = Console.ReadLine();

        Console.WriteLine(ConvertDecimalToBinary(ConvertBinaryToDecimal(hexValue)));
    }

    static string ConvertDecimalToBinary(long decValue)
    {
        string sum = "";

        byte baseValue = 2;

        do
        {
            long reminder = decValue % baseValue;
            sum = reminder + sum;
            decValue /= baseValue;
        }
        while (decValue != 0);

        return sum;
    }

    public static long ConvertBinaryToDecimal(string hexValue)
    {
        long sum = 0;

        byte baseValue = 16;

        foreach (char digit in hexValue)
        {
            sum = hexDigits[digit] + sum * baseValue;
        }

        return sum;
    }

    public static Dictionary<char, long> hexDigits = new Dictionary<char, long>()
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
}
