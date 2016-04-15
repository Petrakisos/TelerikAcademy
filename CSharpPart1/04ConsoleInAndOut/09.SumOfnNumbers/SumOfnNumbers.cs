using System;

class NumbersFromOneToN
{
    static void Main()
    {
        double n = double.Parse(Console.ReadLine());
        double r = 0;

        for (double i = 1; i <= n; i++)
        {
            double n1 = double.Parse(Console.ReadLine());
            r += n1;
        }

        Console.WriteLine(r);
    }
}