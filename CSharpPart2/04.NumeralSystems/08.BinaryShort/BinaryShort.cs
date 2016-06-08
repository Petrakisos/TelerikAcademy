using System;

class BinaryShort
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
        int N = int.Parse(Console.ReadLine());

        string binaryRep = "";

        if (N < 0)
        {
            binaryRep += "1";
            int temp = N + 1;
            binaryRep += ConvertDecimalToBinary(short.MaxValue + temp).PadLeft(15, '0');
        }
        else
        {
            binaryRep += "0";
            binaryRep += ConvertDecimalToBinary(N).PadLeft(15, '0');
        }

        Console.WriteLine(binaryRep);
    }
}
