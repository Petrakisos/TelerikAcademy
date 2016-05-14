using System;
using System.Linq;

class FirstLargerThanNeighbours
{
    static int FirstGreaterThanNeighbours(int[] elements)
    {
        int counter = 0;

        for (int i = 1; i < elements.Length - 1; i++)
        {
            if (elements[i] > elements[i - 1] && elements[i] > elements[i + 1])
            {
                counter = i;
                break;
            }
            else
            {
                counter = -1;
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

        Console.WriteLine(FirstGreaterThanNeighbours(elements));
    }
}
