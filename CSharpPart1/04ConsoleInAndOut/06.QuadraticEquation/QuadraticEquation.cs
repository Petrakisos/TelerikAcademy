using System;

class QuadraticEquation
{
    static void Main()
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());

        double x = b * b - 4 * a * c;

        if (x == 0)
        {
            double r1 = (-b / (2 * a));
            Console.WriteLine("{0:F2}", r1);
        }
        else if (x > 0)
        {
            double r1 = (-b - Math.Sqrt(x)) / (2 * a);
            double r2 = (-b + Math.Sqrt(x)) / (2 * a);
            Console.WriteLine("{0:F2}", r1);
            Console.WriteLine("{0:F2}", r2);
        }
        else if (x < 0)
        {
            Console.WriteLine("no real roots");
        }
    }
}