using System;

class BitSwap
{
    static void Main()
    {
        uint n = uint.Parse(Console.ReadLine());
        int p = int.Parse(Console.ReadLine());
        int q = int.Parse(Console.ReadLine());
        int k = int.Parse(Console.ReadLine());

        for (int i = 0; i <= (k - 1); i++)
        {
            if (((n >> p) & 1) != ((n >> q) & 1))
            {
                n = n ^ ((uint)1 << p);
                n = n ^ ((uint)1 << q);
            }
            p++;
            q++;
        }
        Console.WriteLine(n);
    }
}
