using System;
using System.Linq;

class AppearanceCount
{
    static void Main()
    {
        int lenghtOfArray = int.Parse(Console.ReadLine());

        int[] array = Console.ReadLine()
            .Split(' ')
            .Select(int.Parse)
            .ToArray();

        int search = int.Parse(Console.ReadLine());

        Console.WriteLine(AppearanceCounting(array, search));
    }

    static int AppearanceCounting(int[] array, int search)
    {
        int counter = 0;

        foreach (int number in array)
        {
            if (number == search)
            {
                counter++;
            }
        }
        return counter;
    }
}
