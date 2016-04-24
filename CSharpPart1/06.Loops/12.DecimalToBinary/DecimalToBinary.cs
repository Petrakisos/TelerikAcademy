using System;

class DecimalToBinary
{
    static void Main()
    {
        long decNum = long.Parse(Console.ReadLine());
        string binNum = "";
        long reminder = 0;

        while (decNum > 0)
        {
            reminder = decNum % 2;
            binNum = reminder + binNum;
            decNum /= 2;
        }

        Console.WriteLine(binNum);
    }
}
