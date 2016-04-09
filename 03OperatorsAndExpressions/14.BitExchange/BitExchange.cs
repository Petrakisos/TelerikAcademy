using System;

class BitExchange
{
    static void Main()
    {
        uint n = uint.Parse(Console.ReadLine());

        uint b3 = (n >> 3) & 1;
        uint b4 = (n >> 4) & 1;
        uint b5 = (n >> 5) & 1;
        uint b24 = (n >> 24) & 1;
        uint b25 = (n >> 25) & 1;
        uint b26 = (n >> 26) & 1;

        if (b3 != b24)
        {
            n = n ^ (1 << 3);
            n = n ^ (1 << 24);
        }
        if (b4 != b25)
        {
            n ^= (1 << 4);
            n ^= (1 << 25);
        }
        if (b5 != b26)
        {
            n ^= (1 << 5);
            n ^= (1 << 26);
        }
        Console.WriteLine(n);
    }
}
