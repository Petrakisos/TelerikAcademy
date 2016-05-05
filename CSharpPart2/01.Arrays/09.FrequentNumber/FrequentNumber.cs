using System;

class FrequentNumber
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());

        int[] array = new int[N]; // {4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3};

        for (int i = 0; i < array.Length; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }
        int bestRepeats = 0;
        int bestNumber = 0;
        int repeats = 0;

        for (int i = 0; i < array.Length; i++)
        {
            repeats = 0;

            for (int j = 0; j < array.Length; j++)
            {
                if (array[i] == array[j])
                {
                    repeats++;
                }
                if (repeats > bestRepeats)
                {
                    bestRepeats = repeats;
                    bestNumber = array[i];
                }
            }
        }
        Console.WriteLine("{0} ({1} times)", bestNumber, bestRepeats);
    }
}
