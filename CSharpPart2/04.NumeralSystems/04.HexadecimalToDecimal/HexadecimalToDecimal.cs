using System;
using System.Collections.Generic;

class HexadecimalToDecimal
{
    static void Main()
    {
        string hexValue = Console.ReadLine();

        Console.WriteLine(ConvertHexadecimalToDecimal(hexValue));
    }

    static long ConvertHexadecimalToDecimal(string hexlValue)
    {
        long sum = 0;

        byte baseValue = 16;

        foreach (char value in hexlValue)
        {
            sum = hexDigits[value] + sum * baseValue;
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
}