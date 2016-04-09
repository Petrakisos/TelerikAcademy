//Input Output
//2.5
//3	7.50 11.00
//5
//5	25.00 20.00
//3
//4	12.00 14.00

using System;

class Rectangles
{
    static void Main()
    {
        double inputWidth = double.Parse(Console.ReadLine());
        double inputHeight = double.Parse(Console.ReadLine());

        double area = (inputWidth * inputHeight);
        double perimeter = ((inputWidth + inputHeight) * 2);

        Console.WriteLine("{0:0.00} {1:0.00}" , area, perimeter);
    }
}
