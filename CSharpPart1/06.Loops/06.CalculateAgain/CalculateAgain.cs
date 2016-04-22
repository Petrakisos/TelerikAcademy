using System;

class CalculateAgain
{
    static void Main()
    {
        decimal n = decimal.Parse(Console.ReadLine());
        decimal k = decimal.Parse(Console.ReadLine());

        decimal sum = 1;

        for (decimal i = k + 1; i <= n; i++)
        {
            sum *= i;
        }
        Console.WriteLine(sum);
    }
}
