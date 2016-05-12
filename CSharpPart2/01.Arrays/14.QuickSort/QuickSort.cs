using System;

class QuickSort
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());

        int[] array = new int[N];

        for (int i = 0; i < array.Length; i++)
            array[i] = int.Parse(Console.ReadLine());

        // Sort the array
        Quicksort(array, 0, array.Length - 1);

        // Print the sorted array
        for (int i = 0; i < array.Length; i++)
            Console.WriteLine(array[i]);
    }

    public static void Quicksort(int[] elements, int left, int right)
    {
        int i = left;
        int j = right;
        int pivot = elements[(left + right) / 2];

        while (i <= j)
        {
            while (elements[i].CompareTo(pivot) < 0)
                i++;

            while (elements[j].CompareTo(pivot) > 0)
                j--;

            if (i <= j)
            {
                // Swap
                int tmp = elements[i];
                elements[i] = elements[j];
                elements[j] = tmp;

                i++;
                j--;
            }
        }
        // Recursive calls
        if (left < j)
            Quicksort(elements, left, j);

        if (i < right)
            Quicksort(elements, i, right);
    }
}