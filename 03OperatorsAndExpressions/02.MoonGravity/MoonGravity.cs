using System;

class MoonGravity
{
    static void Main()
    {
        double w = double.Parse(Console.ReadLine());
        double moonGravityValue = 17;
        double result = (w * moonGravityValue) / 100;
        Console.WriteLine("{0:0.000}", result);
    }
}
