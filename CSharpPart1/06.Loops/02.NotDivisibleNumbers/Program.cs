using System;

class Program
{
    static void Main()
    {
        int a = 3;
        int b = 7;

        int n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            if ( ((i % a) != 0) && ((i % b) != 0))
            {
                Console.Write("{0} ", i);
            }
        }
    }
}
