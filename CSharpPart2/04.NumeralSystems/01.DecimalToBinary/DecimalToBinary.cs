using System;

class DecimalToBinary
{
    static string ConvertDecimalToBinary(long decimalValue)
    {
        string binary = "";

        byte baseValue = 2;

        do
        {
            long bit = decimalValue % baseValue;
            binary = bit + binary;
            decimalValue /= baseValue;
        }
        while (decimalValue != 0);

        return binary;
    }

    static void Main()
    {
        long decimalValue = long.Parse(Console.ReadLine());

        Console.WriteLine(ConvertDecimalToBinary(decimalValue));
    }
}