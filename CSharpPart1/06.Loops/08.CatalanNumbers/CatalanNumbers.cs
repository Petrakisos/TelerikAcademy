using System;
using System.Numerics;

class CatalanNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        BigInteger nFactoriel = 1;
        BigInteger upFactoriel = 1;     
        BigInteger product = 0;
        BigInteger tempFactoriel = 1;

        for (int i = 1; i <= n; i++)
        {
            nFactoriel *= i;
        }

        for (int j = 1; j <= n + 1; j++)
        {
            upFactoriel *= j;
        }

        for (int k = 1; k <= 2 * n; k++)
        {
            tempFactoriel *= k;
        }

        product = tempFactoriel / (upFactoriel * nFactoriel);

        Console.WriteLine(product);
    }
}

