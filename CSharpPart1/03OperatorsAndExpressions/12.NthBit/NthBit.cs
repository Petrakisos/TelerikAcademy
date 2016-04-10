using System;

class NthBit
{
    static void Main()
    {
        ulong p = ulong.Parse(Console.ReadLine());
        byte n = byte.Parse(Console.ReadLine());

        double pPow = (ulong)Math.Pow(2, 55);

        if ((n < 55) && (p <= pPow))
        {
            ulong result = (p >> n) & 1;
            if (result == 0)
            {
                Console.WriteLine(0);
            }
            else
            {
                Console.WriteLine(1);
            }
        }
    }
}
