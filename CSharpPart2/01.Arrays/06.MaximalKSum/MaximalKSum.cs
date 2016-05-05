using System;

class MaximalKSum
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        int K = int.Parse(Console.ReadLine());

        int[] array = new int[N];

        int sum = 0;

        for (int i = 0; i < array.Length; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }

        Array.Sort(array);
        Array.Reverse(array);

        for (int i = 0; i < K; i++)
        {
            sum += array[i];
        }
        Console.WriteLine(sum);
    }
}