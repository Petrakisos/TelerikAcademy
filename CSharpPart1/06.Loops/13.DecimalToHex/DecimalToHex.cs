using System;

class DecimalToHex
{
    static void Main()
    {
        long decNum = long.Parse(Console.ReadLine());

        string remainder = "";
        string hexNum = "";
        
        long remaiderValue = 0;

        while (decNum > 0)
        {
            remaiderValue = decNum % 16;
            
            switch (remaiderValue)
            {
                case 10: remainder = "A"; break;
                case 11: remainder = "B"; break;
                case 12: remainder = "C"; break;
                case 13: remainder = "D"; break;
                case 14: remainder = "E"; break;
                case 15: remainder = "F"; break;
                default: remainder = remaiderValue.ToString(); break;
            }
            hexNum = remainder + hexNum;
            decNum /= 16;
        }

        Console.WriteLine(hexNum);
    }
}
