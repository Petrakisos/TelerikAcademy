using System;

class Program
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());

        int[] array = new int[N];

        int min;
        int swap;
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < array.Length - 1; i++)
        {
            min = i; // set min to the current index of array

            for (int j = i + 1; j < array.Length; j++) // compare it with each next value
            {
                if (array[j] < array[min])
                {
                    min = j;
                }
            }
            if (min != i)
            {
                swap = array[i];
                array[i] = array[min];
                array[min] = swap;  
            } 
        }
        for (int i = 0; i < N; i++)
        {
            Console.WriteLine(array[i]);
        }
    }
}
