using System;

class Calculate
{
    static void Main()
    {
        ulong n = ulong.Parse(Console.ReadLine());
        double x = double.Parse(Console.ReadLine());

        double sum = 1 + 1 / x;
        ulong factorial = 1;
        double power = 1;
        
        for (ulong i = 2; i <= n; i++)
        {
            factorial *= i;
            power = Math.Pow(x, i);
            sum += (factorial / power);
        }

        Console.WriteLine("{0:F5}", sum);
    }
}
