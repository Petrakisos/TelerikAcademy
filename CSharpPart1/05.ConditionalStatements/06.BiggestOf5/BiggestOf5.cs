using System;

class BiggestOf5
{
    static void Main()
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());
        double d = double.Parse(Console.ReadLine());
        double e = double.Parse(Console.ReadLine());

        if (a >= b)
        {
            if (a >= c)
            {
                Console.WriteLine(a + " 1");
            }
            else
                Console.WriteLine(c + " 2");
        }
        else
        {
            if (b >= c)
            {
                Console.WriteLine(b + " 3");
            }
            else
                Console.WriteLine(c + " 4");
        }
        if (d <= e)
        {
            if (d <= e)
            {
                Console.WriteLine(c + " 5");
            }
            else
                Console.WriteLine(e + " 6");
        }
        else
        {
            if (c >= d)
            {
                Console.WriteLine(d + " 7");
            }
            else
                Console.WriteLine(e + " 8");
        }
    }
}
