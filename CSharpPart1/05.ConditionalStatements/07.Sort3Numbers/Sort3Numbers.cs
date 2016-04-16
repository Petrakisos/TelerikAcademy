using System;

class Sort3Numbers
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());

        if (a > b && a > c && b > c)
        {
            Console.WriteLine("{0} {1} {2}", a, b, c);
        }
        else
        {
            if (b > a && b > c && a > c)
            {
                Console.WriteLine("{0} {1} {2}", b, a, c);
            }
            else
            {
                if (c > a && c > b && a > b)
                {
                    Console.WriteLine("{0} {1} {2}", c, a, b);
                }
                else
                {
                    if (a > b && a > c && c > b)
                    {
                        Console.WriteLine("{0} {1} {2}", a, c, b);
                    }
                    else
                    {
                        if (b > c && b > a && c > a)
                        {
                            Console.WriteLine("{0} {1} {2}", b, c, a);
                        }
                        else
                            Console.WriteLine("{0} {1} {2}", c, b, a);
                    }
                }
            }
        }
    }
}
