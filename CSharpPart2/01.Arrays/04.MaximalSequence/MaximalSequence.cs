using System;

class MaximalSequence
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());

        int[] array = new int[N];

        int length = 1;
        int start = 0;

        for (int i = 0; i < array.Length; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }
        
        for (int j = 1; j < array.Length; j++)
        {
            if (array[j] ==  array[j - 1])
            {
                length++;
                start = Math.Max(start, length);
            }
            else
            {
                length = 1;
            }
        }
        Console.WriteLine(start);
    }
}
