using System;

class Program
{
    static void Main()
    {
        long n = long.Parse(Console.ReadLine());
        long fibo1 = 0;
        long fibo2 = 1;

        if (n == 1)
        {
            Console.WriteLine("0");
        }
        else
        {
            Console.Write("0, 1");
            for (int i = 1; i < n - 1; i++)
            {
                long fibo3 = fibo1 + fibo2;
                fibo1 = fibo2;
                fibo2 = fibo3;
                Console.Write(", {0}", fibo3);
            }
        }
    }
}