using System;

class Program
{
    static void Main()
    {
        int A = int.Parse(Console.ReadLine());
        int B = int.Parse(Console.ReadLine());
        int sum = 0;

        for (int i = A; i <= B; i++)
        {
            for (int divisors = 1; divisors <= i; divisors++)
            {
                if (i % divisors == 0) // find the divisors
                {
                    if (divisors % 2 != 0)
                    {
                        sum += divisors;
                    }
                }
            }
        }
        Console.WriteLine(sum);
    }
}
