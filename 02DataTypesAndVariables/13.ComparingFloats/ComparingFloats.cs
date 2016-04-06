//  5.3
//  6.01	false	The difference of 0.71 is too big(> eps)
//  5.00000001
//  5.00000003	true	The difference 0.00000002 < eps
//  5.00000005
//  5.00000001	true	The difference 0.00000004 < eps
//  -0.0000007
//  0.00000007	true	The difference 0.00000077 < eps
//  -4.999999
//  -4.999998	false	Border case. The difference 0.000001 == eps.We consider the numbers are different.
//  4.999999
//  4.999998	false	Border case. The difference 0.000001 == eps.We consider the numbers are different.

using System;

class ComparingFloats
{
    static void Main()
    {
        
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double equal = Math.Abs(a - b);
        double eps = 0.000001;
        if (equal > eps)
        {
            Console.WriteLine("false");
        }
        else
        {
            Console.WriteLine("true");
        }
    }
}