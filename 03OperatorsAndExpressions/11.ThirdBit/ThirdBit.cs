using System;

class ThirdBit
{
    static void Main()
    {
        
        uint inputNumber = uint.Parse(Console.ReadLine());
        uint mask = 1 << 3;
        uint bit = inputNumber & mask;

        if (bit > 0)
        {
            Console.WriteLine(1);
        }
        else
        {
            Console.WriteLine(0);
        }
    }
}
