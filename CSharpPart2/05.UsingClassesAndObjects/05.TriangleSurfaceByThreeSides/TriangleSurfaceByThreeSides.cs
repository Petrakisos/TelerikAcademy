using System;

class TriangleSurfaceByThreeSides
{
    static void Main()
    {
        double area = FindTheSurface();

        Console.WriteLine("{0:F2}", area);
    }

    private static double FindTheSurface()
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());

        double p = (a + b + c) / 2;

        double area = Math.Sqrt(p * (p - a) * (p - b) * (p - c));

        return area;
    }
}
