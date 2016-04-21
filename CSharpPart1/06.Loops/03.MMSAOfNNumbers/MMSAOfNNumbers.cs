using System;
using System.Linq;

class MMSAOfNNumbers
{
    static void Main()
    {

        double sum = 0;
        double avg = 0;

        int n = int.Parse(Console.ReadLine());

        double[] nOfNumbers = new double[n];

        for (int i = 0; i < n; i++)
        {
            nOfNumbers[i] = double.Parse(Console.ReadLine());
            sum += nOfNumbers[i];
        }
        double min = nOfNumbers.Min();
        double max = nOfNumbers.Max();

        avg = sum / n;

        Console.WriteLine("min={0:F2}", min);
        Console.WriteLine("max={0:F2}", max);
        Console.WriteLine("sum={0:F2}", sum);
        Console.WriteLine("avg={0:F2}", avg);
    }
}
