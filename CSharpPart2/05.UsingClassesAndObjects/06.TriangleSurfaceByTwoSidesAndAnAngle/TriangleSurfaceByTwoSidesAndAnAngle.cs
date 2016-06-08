using System;

class TriangleSurfaceByTwoSidesAndAnAngle
{
    static void Main()
    {
        double firstSide = double.Parse(Console.ReadLine());
        double secondSide = double.Parse(Console.ReadLine());
        double angle = double.Parse(Console.ReadLine());

        double degree = angle * (Math.PI / 180);

        double area = (firstSide * secondSide) * Math.Sin(degree) / 2;

        Console.WriteLine("{0:F2}", area);
    }
}
