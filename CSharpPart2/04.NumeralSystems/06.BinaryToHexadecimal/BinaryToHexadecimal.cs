using System;

class BinaryToHexadecimal
{
    static long ConvertBinaryToDecimal(string binary)
    {
        long sum = 0;

        byte baseValue = 2;

        foreach (char bit in binary)
        {
            sum = (bit - '0') + sum * baseValue;
        }

        return sum;
    }

    static string ConvertDecimalToHexadecimal(long decimalValue)
    {
        string sum = "";

        string[] hexDigits = "0 1 2 3 4 5 6 7 8 9 A B C D E F".Split(' ');

        int baseValue = 16;

        do
        {
            long bit = decimalValue % baseValue;
            sum = hexDigits[bit] + sum;
            decimalValue /= baseValue;
        }
        while (decimalValue != 0);

        return sum;
    }

    static void Main()
    {
        string N = Console.ReadLine();

        Console.WriteLine(ConvertDecimalToHexadecimal(ConvertBinaryToDecimal(N)));
    }
}
