using System;

class QuickSort
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());

        int[] array = new int[N];

        for (int i = 0; i < array.Length; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }

        QuickSortRecursive(array, 0, array.Length - 1);

        for (int i = 0; i < array.Length; i++)
        {
            Console.WriteLine(array[i]);
        }
    }

    static public int Partition(int[] numbers, int left, int right)
    {
        int pivot = numbers[left];

        while (true)
        {
            while (numbers[left] < pivot)
            {
                left++;
            }

            while (numbers[right] > pivot)
            {
                right--;
            }

            if (left < right)
            {
                int temp = numbers[right];
                numbers[right] = numbers[left];
                numbers[left] = temp;
            }
            else
            {
                return right;
            }
        }
    }

    static public void QuickSortRecursive(int[] array, int left, int right)
    {

        if (left < right)
        {
            int pivot = Partition(array, left, right);

            if (pivot > 1)
            {
                QuickSortRecursive(array, left, pivot - 1);
            }

            if (pivot + 1 < right)
            {
                QuickSortRecursive(array, pivot + 1, right);
            }
        }
    }
}