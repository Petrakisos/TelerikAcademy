using System;
using System.Numerics;

class TrailingZeroInN
{
    static void Main()
    {
        // read input
        int N = int.Parse(Console.ReadLine());

        //logic
        int counter = 0;
        int divider = 5;

        while (N / divider >= 1)
        {
            counter += N / divider;
            divider *= 5;
        }

        // print result
        Console.WriteLine(counter);
    }
}
