using System;

class Trapezoids
{
    static void Main()
    {
        double sideA = double.Parse(Console.ReadLine());
        double sideB = double.Parse(Console.ReadLine());
        double height = double.Parse(Console.ReadLine());
        double area = (height * ((sideA + sideB) / 2));

        Console.WriteLine("{0:0.0000000}", area);
    }
}
