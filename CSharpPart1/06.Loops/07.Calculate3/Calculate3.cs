using System;
using System.Numerics;

class Calculate3
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int k = int.Parse(Console.ReadLine());

        BigInteger nFactorial = 1;
        BigInteger kFactorial = 1;
        BigInteger product = 0;
        BigInteger factorielProduct = 1;

        for (int i = 1; i < n + 1; i++)
        {
            nFactorial *= i;

            if (i <= k)
            {
                kFactorial *= i;
            }
        }

        for (int j = n - k; j > 1; j--)
        {
            factorielProduct *= j;
        }

        product = (nFactorial / (kFactorial * factorielProduct));
        Console.WriteLine(product);
    }
}