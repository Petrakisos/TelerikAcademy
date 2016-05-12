using System;

class RemoveElementsFromArray
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());

        int[] array = new int[N];
        int[] store = new int[N];

        int max = 0;

        for (int i = 0; i < array.Length; i++)
            array[i] = int.Parse(Console.ReadLine());

        for (int end = 0; end < array.Length; end++)
        {
            max = 0;

            for (int start = 0; start < end; start++)
            {

                if (array[end] >= array[start])
                    if (store[start] > max)
                        max = store[start];
            }

            store[end] = max + 1;
        }

        max = 0;

        for (int i = 0; i < N; i++)
            if (store[i] > max)
                max = store[i];

        Console.WriteLine(N - max);
    }
}