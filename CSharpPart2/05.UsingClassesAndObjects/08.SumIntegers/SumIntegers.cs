using System;
using System.Linq;

class SumIntegers
{
    static void Main()
    {
        int[] numbers = Console.ReadLine()
                   .Split(' ')
                   .Select(int.Parse)
                   .ToArray();

        Console.WriteLine(CalculateSumOfIntegers(numbers));
    }

    public static int CalculateSumOfIntegers(int[] numbers)
    {
        int sum = 0;

        foreach (int integer in numbers)
        {
            sum += integer;
        }

        return sum;
    }
}
