using System;

class BinaryToDecimal
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

    static void Main()
    {
        string N = Console.ReadLine();

        Console.WriteLine(ConvertBinaryToDecimal(N));
    }
}
