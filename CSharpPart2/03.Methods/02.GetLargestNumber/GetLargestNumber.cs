using System;
using System.Linq;

class GetLargestNumber
{
    static void Main()
    {
        int[] sequence = Console.ReadLine()
            .Split(' ')
            .Select(int.Parse)
            .ToArray();

            Console.WriteLine(GetMax(sequence[0], GetMax(sequence[1], sequence[2])));
    }

    static int GetMax(int firstNumber, int secondNumber)
    {
        if (firstNumber > secondNumber)
        {
            return firstNumber;
        }
        else
        {
            return secondNumber;
        }
    }
}
