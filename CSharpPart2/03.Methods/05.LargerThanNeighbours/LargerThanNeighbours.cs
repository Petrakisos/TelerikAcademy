using System;
using System.Linq;

class LargerThanNeighbours
{
    static int BiggerThanNeighbours(int[] elements)
    {
        int counter = 0;

        for (int i = 1; i < elements.Length - 1; i++)
        {
            if (elements[i] > elements[i - 1] && elements[i] > elements[i + 1])
            {
                counter++;
            }
        }
        return counter;
    }

    static void Main()
    {
        int arraySize = int.Parse(Console.ReadLine());

        int[] elements = Console.ReadLine()
       .Split(' ')
       .Select(int.Parse)
       .ToArray();

        Console.WriteLine(BiggerThanNeighbours(elements));
    }
}
