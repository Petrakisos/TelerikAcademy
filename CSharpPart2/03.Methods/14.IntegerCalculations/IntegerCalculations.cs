using System;
using System.Linq;

class IntegerCalculations
{
    static void Main()
    {
        int[] elements = ReadElements();

        PrintAllCalculations(elements);
    }

    static int[] ReadElements()
    {
        return Console.ReadLine()
            .Split(' ')
            .Select(int.Parse)
            .ToArray();
    }

    static int CalculateMinimum(int[] numbers)
    {
        int minimum = numbers[0];

        for (int i = 0; i < numbers.Length; i++)
        {
            if (minimum > numbers[i])
            {
                minimum = numbers[i];
            }
        }

        return minimum;
    }

    static int CalculateMaximum(int[] numbers)
    {
        int maximum = numbers[0];

        for (int i = 0; i < numbers.Length; i++)
        {
            if (maximum < numbers[i])
            {
                maximum = numbers[i];
            }
        }

        return maximum;
    }

    static double CalculateAverage(int[] numbers)
    {
        double sum = 0.00;

        for (int i = 0; i < numbers.Length; i++)
        {
            sum += numbers[i];
        }

        double average = sum / numbers.Length;

        return average;
    }

    static long CalculateSum(int[] numbers)
    {
        long sum = 0;

        foreach (var number in numbers)
        {
            sum += number;
        }

        return sum;
    }

    static long CalculateProduct(int[] numbers)
    {
        long product = 1;

        foreach (int number in numbers)
        {
            product *= number;
        }

        return product;
    }

    static void PrintAllCalculations(int[] elements)
    {
        Console.WriteLine(CalculateMinimum(elements));

        Console.WriteLine(CalculateMaximum(elements));

        Console.WriteLine("{0:F2}", CalculateAverage(elements));

        Console.WriteLine(CalculateSum(elements));

        Console.WriteLine(CalculateProduct(elements));
    }
}
