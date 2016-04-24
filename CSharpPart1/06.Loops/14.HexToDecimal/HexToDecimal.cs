using System;

class HexToDecimal
{
    static void Main()
    {
        string hexNum = Console.ReadLine();

        long decNum = 0;
        int multiply = 1;

        for (int i = 0; i < hexNum.Length; i++)
        {
            switch (hexNum[hexNum.Length - i - 1])
            {
                case 'A': multiply = 10; break;
                case 'B': multiply = 11; break;
                case 'C': multiply = 12; break;
                case 'D': multiply = 13; break;
                case 'E': multiply = 14; break;
                case 'F': multiply = 15; break;
                default: multiply = int.Parse(hexNum[hexNum.Length - i - 1].ToString()); break;
            }
            decNum += multiply * (long)Math.Pow(16, i);
        }

        Console.WriteLine(decNum);
    }
}
