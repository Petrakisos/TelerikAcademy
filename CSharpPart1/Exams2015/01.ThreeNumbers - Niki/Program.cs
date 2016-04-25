using System;

class ThreeNumbers
{
    static void Main()
    {
        // read input
        int A = int.Parse(Console.ReadLine());
        int B = int.Parse(Console.ReadLine());
        int C = int.Parse(Console.ReadLine());

        double avg = (A + B + C) / 3.0;

        //logic
        int max = A;
        if (B > max)
        {
            max = B;
        }
        if (C > max)
        {
            max = C;
        }

        int min = A;
        if (B < min)
        {
            min = B;
        }
        if (C < min)
        {
            min = C;
        }

        //print result
        Console.WriteLine(max);
        Console.WriteLine(min);
        Console.WriteLine("{0:F2}", avg);
    }
}
