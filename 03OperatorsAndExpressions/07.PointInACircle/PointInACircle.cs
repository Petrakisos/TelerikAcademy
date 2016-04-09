//Input Output
//-2
//0	yes 2.00
//-1
//2	no 2.24
//1.5
//-1	yes 1.80
//-1.5
//-1.5	no 2.12
//100
//-30	no 104.40
//0
//0	yes 0.00
//0.2
//-0.8	yes 0.82
//0.9
//-1.93	no 2.13
//1
//1.655	yes 1.93
//0
//1	yes 1.00
using System;

class PointInACircle
{
    static void Main()
    {
        double x = double.Parse(Console.ReadLine());
        double y = double.Parse(Console.ReadLine());

        double radius = 2;

        double distance = Math.Sqrt((x * x) + (y * y));

        if (distance <= radius)
        {
            Console.WriteLine("yes {0:0.00}", distance);
        }
        else
        {
            Console.WriteLine("no {0:0.00}", distance);
        }
    }
}