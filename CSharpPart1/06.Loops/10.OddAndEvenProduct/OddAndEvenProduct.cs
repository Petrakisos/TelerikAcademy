using System;

class OddAndEvenProduct
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        string[] stringInput = Console.ReadLine().Split(' ');

        long productOdd = 1;
        long productEven = 1;

        int[] container = new int[n];

        for (int i = 0; i < n; i++)
        {
            container[i] = int.Parse(stringInput[i]);
        }
        
        for (int i = 0; i < n; i++)
        {
            if (i % 2 == 0)
            {
                productOdd *= container[i];
            }
            else
            {
                productEven *= container[i];
            }
        }
        if (productOdd == productEven)
        {
            Console.WriteLine("yes {0}", productOdd);
        }
        else
        {
            Console.WriteLine("no {0} {1}", productOdd, productEven);
        }
    }
}
